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
    public class OrdersProductsController : ControllerBase
    {
        private readonly TodoContext _context;

        public OrdersProductsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/OrdersProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdersProducts>>> GetOrdersProducts()
        {
            return await _context.OrdersProducts.ToListAsync();
        }

        // GET: api/OrdersProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdersProducts>> GetOrdersProducts(int id)
        {
            var ordersProducts = await _context.OrdersProducts.FindAsync(id);

            if (ordersProducts == null)
            {
                return NotFound();
            }

            return ordersProducts;
        }

        // PUT: api/OrdersProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdersProducts(int id, OrdersProducts ordersProducts)
        {
            if (id != ordersProducts.id)
            {
                return BadRequest();
            }

            _context.Entry(ordersProducts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersProductsExists(id))
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

        // POST: api/OrdersProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrdersProducts>> PostOrdersProducts(OrdersProducts ordersProducts)
        {
            _context.OrdersProducts.Add(ordersProducts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdersProducts", new { id = ordersProducts.id }, ordersProducts);
        }

        // DELETE: api/OrdersProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdersProducts(int id)
        {
            var ordersProducts = await _context.OrdersProducts.FindAsync(id);
            if (ordersProducts == null)
            {
                return NotFound();
            }

            _context.OrdersProducts.Remove(ordersProducts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdersProductsExists(int id)
        {
            return _context.OrdersProducts.Any(e => e.id == id);
        }
    }
}
