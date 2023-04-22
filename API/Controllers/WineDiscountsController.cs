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
    public class WineDiscountsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public WineDiscountsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/WineDiscounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WineDiscount>>> GetWineDiscounts()
        {
            return await _context.WineDiscounts.ToListAsync();
        }

        // GET: api/WineDiscounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WineDiscount>> GetWineDiscount(int id)
        {
            var wineDiscount = await _context.WineDiscounts.FindAsync(id);

            if (wineDiscount == null)
            {
                return NotFound();
            }

            return wineDiscount;
        }

        // PUT: api/WineDiscounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWineDiscount(int id, WineDiscount wineDiscount)
        {
            if (id != wineDiscount.WineDiscountID)
            {
                return BadRequest();
            }

            _context.Entry(wineDiscount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WineDiscountExists(id))
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

        // POST: api/WineDiscounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WineDiscount>> PostWineDiscount(WineDiscount wineDiscount)
        {
            _context.WineDiscounts.Add(wineDiscount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWineDiscount", new { id = wineDiscount.WineDiscountID }, wineDiscount);
        }

        // DELETE: api/WineDiscounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWineDiscount(int id)
        {
            var wineDiscount = await _context.WineDiscounts.FindAsync(id);
            if (wineDiscount == null)
            {
                return NotFound();
            }

            _context.WineDiscounts.Remove(wineDiscount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WineDiscountExists(int id)
        {
            return _context.WineDiscounts.Any(e => e.WineDiscountID == id);
        }
    }
}
