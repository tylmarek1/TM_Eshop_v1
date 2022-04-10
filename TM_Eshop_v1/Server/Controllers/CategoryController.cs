using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TM_Eshop_v1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getallcategories")]
        public async Task<ActionResult<ServiceResponce<List<Category>>>> GetCategoriesAsync()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }
    }
}
