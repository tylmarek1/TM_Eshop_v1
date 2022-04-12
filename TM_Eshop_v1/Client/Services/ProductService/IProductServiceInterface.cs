namespace TM_Eshop_v1.Client.Services.ProductService
{
    public interface IProductServiceInterface
    {
        event Action ProductChanged;
        List<Product> Products { get; set; }
        string Message { get; set; }
        Task GetProducts(string? catUrl = null);
        Task<ServiceResponce<Product>> GetProduct(int proId);
        Task Search(string searchString);
    }
}
