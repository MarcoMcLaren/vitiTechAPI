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
    public class WriteOffItemsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public WriteOffItemsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/WriteOffItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WriteOffItem>>> GetWriteOffItems()
        {
            return await _context.WriteOffItems.ToListAsync();
        }

        // GET: api/WriteOffItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WriteOffItem>> GetWriteOffItem(int id)
        {
            var writeOffItem = await _context.WriteOffItems.FindAsync(id);

            if (writeOffItem == null)
            {
                return NotFound();
            }

            return writeOffItem;
        }

        // PUT: api/WriteOffItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWriteOffItem(int id, WriteOffItem writeOffItem)
        {
            if (id != writeOffItem.WriteOffItemID)
            {
                return BadRequest();
            }

            _context.Entry(writeOffItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WriteOffItemExists(id))
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

        // POST: api/WriteOffItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WriteOffItem>> PostWriteOffItem(WriteOffItem writeOffItem)
        {
            _context.WriteOffItems.Add(writeOffItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWriteOffItem", new { id = writeOffItem.WriteOffItemID }, writeOffItem);
        }

        // DELETE: api/WriteOffItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWriteOffItem(int id)
        {
            var writeOffItem = await _context.WriteOffItems.FindAsync(id);
            if (writeOffItem == null)
            {
                return NotFound();
            }

            _context.WriteOffItems.Remove(writeOffItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WriteOffItemExists(int id)
        {
            return _context.WriteOffItems.Any(e => e.WriteOffItemID == id);
        }
    }
}
