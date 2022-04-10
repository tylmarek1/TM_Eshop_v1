namespace TM_Eshop_v1.Client.Services.ProductService
{
    public interface IProductServiceInterface
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
