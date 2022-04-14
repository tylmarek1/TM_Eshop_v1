namespace TM_Eshop_v1.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(Cart cartIt);
        Task<List<Cart>> GetCart();
        Task<List<CartResponce>> GetProInCart();
    }
}
