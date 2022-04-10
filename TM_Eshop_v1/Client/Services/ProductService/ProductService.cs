using System.Net.Http.Json;

namespace TM_Eshop_v1.Client.Services.ProductService
{
    public class ProductService : IProductServiceInterface
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var results = await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product/getallproducts");
            if (results != null && results.Data != null)
                Products = results.Data;
        }
    }
}
