using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRMenuSystem.Data;
using QRMenuSystem.Models;

namespace QRMenuSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table>>> GetTables()
        {
            return await _context.Tables.ToListAsync();
        }

        // PUT: api/Tables/5/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateTableStatus(int id, [FromBody] string newStatus)
        {
            var table = await _context.Tables.FindAsync(id);

            if (table == null)
                return NotFound();

            table.Status = newStatus;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Tables
        [HttpPost]
        public async Task<ActionResult<Table>> CreateTable(Table table)
        {
            _context.Tables.Add(table);
            await _context.SaveChangesAsync();
            return Ok(table);
        }

    }
}
