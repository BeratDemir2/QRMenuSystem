using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRMenuSystem.Data;
using QRMenuSystem.Models;

namespace QRMenuSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders/active
        [HttpGet("active")]
        public async Task<ActionResult<IEnumerable<Order>>> GetActiveOrders()
        {
            return await _context.Orders
                .Where(o => o.Status != "Ready")
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.MenuItem)
                .ToListAsync();
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            order.Status = "Pending";

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(order);
        }

        // POST: api/Orders/5/addItem
        [HttpPost("{orderId}/addItem")]
        public async Task<IActionResult> AddItemToOrder(int orderId, OrderDetail detail)
        {
            var order = await _context.Orders.FindAsync(orderId);

            if (order == null)
                return NotFound();

            detail.OrderId = orderId;
            _context.OrderDetails.Add(detail);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/Orders/5/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int id, [FromBody] string newStatus)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            order.Status = newStatus;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
