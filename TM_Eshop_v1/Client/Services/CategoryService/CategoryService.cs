namespace TM_Eshop_v1.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var responce = await _http.GetFromJsonAsync<ServiceResponce<List<Category>>>("api/category/getallcategories");
            if (results != null && results.Data != null)
                Categories = responce.Data;
        }
    }
}
