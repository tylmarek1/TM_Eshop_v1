using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TM_Eshop_v1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductServiceInterface _productService;

        public ProductController(ProductServiceInterface productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return Ok(await _productService.GetAll());
        }
    }
}
