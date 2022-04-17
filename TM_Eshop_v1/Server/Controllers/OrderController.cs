using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TM_Eshop_v1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }

        [HttpPost("createorder")]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(await GetDbOrder());
        }

        private async Task<List<Order>> GetDbOrder()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
