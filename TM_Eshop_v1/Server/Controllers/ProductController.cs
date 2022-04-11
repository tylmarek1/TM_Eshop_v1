using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TM_Eshop_v1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServiceInterface _productService;

        public ProductController(IProductServiceInterface productService)
        {
            _productService = productService;
        }

        [HttpGet("getallproducts")]
        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
        [HttpGet("{proId}")]
        public async Task<ActionResult<ServiceResponce<Product>>> GetProduct(int proId)
        {
            var result = await _productService.GetProductAsync(proId);
            return Ok(result);
        }


        [HttpGet("category/{catUrl}")]
        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProductsByCategory(string catUrl)
        {
            var result = await _productService.GetProductsByCategory(catUrl);
            return Ok(result);
        }
    }
}
