using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderCustomersController : ControllerBase
    {
        private readonly TodoContext _context;

        public OrderCustomersController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/OrderCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderCustomers>>> GetOrderCustomers()
        {
            return await _context.OrderCustomers.ToListAsync();
        }

        // GET: api/OrderCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderCustomers>> GetOrderCustomers(int id)
        {
            var orderCustomers = await _context.OrderCustomers.FindAsync(id);

            if (orderCustomers == null)
            {
                return NotFound();
            }

            return orderCustomers;
        }

        // PUT: api/OrderCustomers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderCustomers(int id, OrderCustomers orderCustomers)
        {
            if (id != orderCustomers.id)
            {
                return BadRequest();
            }

            _context.Entry(orderCustomers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderCustomersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderCustomers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderCustomers>> PostOrderCustomers(OrderCustomers orderCustomers)
        {
            _context.OrderCustomers.Add(orderCustomers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderCustomers", new { id = orderCustomers.id }, orderCustomers);
        }

        // DELETE: api/OrderCustomers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderCustomers(int id)
        {
            var orderCustomers = await _context.OrderCustomers.FindAsync(id);
            if (orderCustomers == null)
            {
                return NotFound();
            }

            _context.OrderCustomers.Remove(orderCustomers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderCustomersExists(int id)
        {
            return _context.OrderCustomers.Any(e => e.id == id);
        }
    }
}
