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
    public class RefundResponsesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public RefundResponsesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/RefundResponses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefundResponse>>> GetRefundResponses()
        {
            return await _context.RefundResponses.ToListAsync();
        }

        // GET: api/RefundResponses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefundResponse>> GetRefundResponse(int id)
        {
            var refundResponse = await _context.RefundResponses.FindAsync(id);

            if (refundResponse == null)
            {
                return NotFound();
            }

            return refundResponse;
        }

        // PUT: api/RefundResponses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefundResponse(int id, RefundResponse refundResponse)
        {
            if (id != refundResponse.RefundResponseID)
            {
                return BadRequest();
            }

            _context.Entry(refundResponse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefundResponseExists(id))
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

        // POST: api/RefundResponses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RefundResponse>> PostRefundResponse(RefundResponse refundResponse)
        {
            _context.RefundResponses.Add(refundResponse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefundResponse", new { id = refundResponse.RefundResponseID }, refundResponse);
        }

        // DELETE: api/RefundResponses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRefundResponse(int id)
        {
            var refundResponse = await _context.RefundResponses.FindAsync(id);
            if (refundResponse == null)
            {
                return NotFound();
            }

            _context.RefundResponses.Remove(refundResponse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefundResponseExists(int id)
        {
            return _context.RefundResponses.Any(e => e.RefundResponseID == id);
        }
    }
}
