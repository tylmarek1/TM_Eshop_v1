namespace TM_Eshop_v1.Server.Services.ProductService
{
    public interface IProductServiceInterface
    {
        Task<ServiceResponce<List<Product>>> GetProductsAsync();
        Task<ServiceResponce<List<Product>>> GetProductsByCategory(string catUrl);
    }
}
