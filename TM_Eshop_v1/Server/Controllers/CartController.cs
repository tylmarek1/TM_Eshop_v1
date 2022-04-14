using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TM_Eshop_v1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("cart")]
        public async Task<ActionResult<ServiceResponce<List<CartResponce>>>> GetProInCart(List<Cart> carts)
        {
            var result = await _cartService.GetProInCart(carts);
            return Ok(result);
        }
    }
}
