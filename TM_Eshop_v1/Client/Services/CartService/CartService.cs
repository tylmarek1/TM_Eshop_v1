using System.Net.Http.Json;
using Blazored.LocalStorage;

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

        public async Task AddToCart(Cart cartIt)
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            if (cart == null)
            {
                cart = new List<Cart>();
            }
            cart.Add(cartIt);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task<List<Cart>> GetCart()
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            if (cart == null)
            {
                cart = new List<Cart>();
            }
            return cart;
        }

        public async Task<List<CartResponce>> GetProInCart()
        {
            var cart = await _localStorage.GetItemAsync<List<Cart>>("cart");
            var responce = await _http.PostAsJsonAsync("api/cart/cart", cart);
            var cartPro = await responce.Content.ReadFromJsonAsync<ServiceResponce<List<CartResponce>>>();
            return cartPro.Data;

            
        }
    }
}
