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
        public string Message { get; set; } = "Produkty se načítají...";

        public event Action ProductChanged;

        public async Task<ServiceResponce<Product>> GetProduct(int proId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<Product>>($"api/product/{proId}");
            return result;
        }

        public async Task GetProducts(string? catUrl = null)
        {
            var results = catUrl == null?
                await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product/getallproducts"): 
                await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>($"api/product/category/{catUrl}");
            if (results != null && results.Data != null)
                Products = results.Data;

            ProductChanged.Invoke();
        }

        public async Task Search(string searchString)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>($"api/product/search/{searchString}");
            if (result != null && result.Data != null)
                Products = result.Data;
            if (Products.Count == 0)
                Message = "Tady nic není...";
            ProductChanged?.Invoke();
        }
    }
}
