namespace TM_Eshop_v1.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponce<List<CartResponce>>> GetCartProducts(List<CartItem> cartItems);
    }
}
