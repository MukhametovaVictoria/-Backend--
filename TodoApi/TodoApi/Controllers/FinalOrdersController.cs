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
    public class FinalOrdersController : ControllerBase
    {
        private readonly TodoContext _context;

        public FinalOrdersController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/FinalOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinalOrders>>> GetFinalOrders()
        {
            return await _context.FinalOrders.ToListAsync();
        }

        // GET: api/FinalOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FinalOrders>> GetFinalOrders(int id)
        {
            var finalOrders = await _context.FinalOrders.FindAsync(id);

            if (finalOrders == null)
            {
                return NotFound();
            }

            return finalOrders;
        }

        private bool FinalOrdersExists(int id)
        {
            return _context.FinalOrders.Any(e => e.id == id);
        }

    }
}
