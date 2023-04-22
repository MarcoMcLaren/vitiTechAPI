using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinePricesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public WinePricesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/WinePrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WinePrice>>> GetWinePrices()
        {
            return await _context.WinePrices.ToListAsync();
        }

        // GET: api/WinePrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WinePrice>> GetWinePrice(int id)
        {
            var winePrice = await _context.WinePrices.FindAsync(id);

            if (winePrice == null)
            {
                return NotFound();
            }

            return winePrice;
        }

        // PUT: api/WinePrices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWinePrice(int id, WinePrice winePrice)
        {
            if (id != winePrice.WinePriceID)
            {
                return BadRequest();
            }

            _context.Entry(winePrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WinePriceExists(id))
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

        // POST: api/WinePrices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WinePrice>> PostWinePrice(WinePrice winePrice)
        {
            _context.WinePrices.Add(winePrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWinePrice", new { id = winePrice.WinePriceID }, winePrice);
        }

        // DELETE: api/WinePrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWinePrice(int id)
        {
            var winePrice = await _context.WinePrices.FindAsync(id);
            if (winePrice == null)
            {
                return NotFound();
            }

            _context.WinePrices.Remove(winePrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WinePriceExists(int id)
        {
            return _context.WinePrices.Any(e => e.WinePriceID == id);
        }
    }
}
