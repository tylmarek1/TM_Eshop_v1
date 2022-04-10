namespace TM_Eshop_v1.Server.Services.ProductService
{
    public interface ProductServiceInterface
    {
        Task<List<Product>> GetAll();
    }
}
