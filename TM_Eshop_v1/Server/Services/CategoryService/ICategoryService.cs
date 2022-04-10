namespace TM_Eshop_v1.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponce<List<Category>>> GetCategoriesAsync();
    }
}
