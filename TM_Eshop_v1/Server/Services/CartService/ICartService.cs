namespace TM_Eshop_v1.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponce<List<CartResponce>>> GetProInCart(List<Cart> carts);
    }
}
