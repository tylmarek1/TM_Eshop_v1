namespace TM_Eshop_v1.Server.Services.ProductService
{
    public interface IProductServiceInterface
    {
        Task<ServiceResponce<List<Product>>> GetProductsAsync();
        Task<ServiceResponce<Product>> GetProductAsync(int proId);
        Task<ServiceResponce<List<Product>>> GetProductsByCategory(string catUrl);
        Task<ServiceResponce<List<Product>>> Search(string searchString);
    }
}
