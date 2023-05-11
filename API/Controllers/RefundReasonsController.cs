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
    public class RefundReasonsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public RefundReasonsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/RefundReasons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefundReason>>> GetRefundReasons()
        {
            return await _context.RefundReasons.ToListAsync();
        }

        // GET: api/RefundReasons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefundReason>> GetRefundReason(int id)
        {
            var refundReason = await _context.RefundReasons.FindAsync(id);

            if (refundReason == null)
            {
                return NotFound();
            }

            return refundReason;
        }

        // PUT: api/RefundReasons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefundReason(int id, RefundReason refundReason)
        {
            if (id != refundReason.RefundReasonID)
            {
                return BadRequest();
            }

            _context.Entry(refundReason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefundReasonExists(id))
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

        // POST: api/RefundReasons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RefundReason>> PostRefundReason(RefundReason refundReason)
        {
            _context.RefundReasons.Add(refundReason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefundReason", new { id = refundReason.RefundReasonID }, refundReason);
        }

        // DELETE: api/RefundReasons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRefundReason(int id)
        {
            var refundReason = await _context.RefundReasons.FindAsync(id);
            if (refundReason == null)
            {
                return NotFound();
            }

            _context.RefundReasons.Remove(refundReason);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefundReasonExists(int id)
        {
            return _context.RefundReasons.Any(e => e.RefundReasonID == id);
        }
    }
}
