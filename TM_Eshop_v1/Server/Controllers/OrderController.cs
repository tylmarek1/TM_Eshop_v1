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
        [HttpGet("orders")]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            var orders = await _context.Orders.Include(o => o.Buyer).ToListAsync();
            return Ok(orders);
        }

        [HttpGet("buyers")]
        public async Task<ActionResult<List<Buyer>>> GetBuyers()
        {
            var buyers = await _context.Buyers.ToListAsync();
            return Ok(buyers);
        }
        [HttpPost("postorders")]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(await GetDbOrders());
        }

        private async Task<List<Order>> GetDbOrders()
        {
            return await _context.Orders.Include(p => p.Buyer).ToListAsync();
        }
    }
}
