namespace TM_Eshop_v1.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;

        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }
        public event Action OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null) { cart = new List<CartItem>(); }
            cart.Add(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null) { cart = new List<CartItem>(); }
            return cart;
        }

        public async Task<List<CartResponce>> GetCartProducts()
        {
            var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            var responce = await _http.PostAsJsonAsync("api/cart/products", cartItems);
            var cartProducts = await responce.Content.ReadFromJsonAsync<ServiceResponce<List<CartResponce>>>();
            return cartProducts.Data;
        }

        public async Task RemoveFromCart(int productId)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null) { return; }
            var cartItem = cart.Find(f => f.ProductId == productId);
            if (cartItem != null) 
            { 
                cart.Remove(cartItem);
                await _localStorage.SetItemAsync("cart", cart);
                OnChange.Invoke();
            }
        }
    }
}
