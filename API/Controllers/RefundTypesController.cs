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
    public class RefundTypesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public RefundTypesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/RefundTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefundType>>> GetRefundTypes()
        {
            return await _context.RefundTypes.ToListAsync();
        }

        // GET: api/RefundTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RefundType>> GetRefundType(int id)
        {
            var refundType = await _context.RefundTypes.FindAsync(id);

            if (refundType == null)
            {
                return NotFound();
            }

            return refundType;
        }

        // PUT: api/RefundTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefundType(int id, RefundType refundType)
        {
            if (id != refundType.RefundTypeID)
            {
                return BadRequest();
            }

            _context.Entry(refundType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefundTypeExists(id))
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

        // POST: api/RefundTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RefundType>> PostRefundType(RefundType refundType)
        {
            _context.RefundTypes.Add(refundType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefundType", new { id = refundType.RefundTypeID }, refundType);
        }

        // DELETE: api/RefundTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRefundType(int id)
        {
            var refundType = await _context.RefundTypes.FindAsync(id);
            if (refundType == null)
            {
                return NotFound();
            }

            _context.RefundTypes.Remove(refundType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefundTypeExists(int id)
        {
            return _context.RefundTypes.Any(e => e.RefundTypeID == id);
        }
    }
}
