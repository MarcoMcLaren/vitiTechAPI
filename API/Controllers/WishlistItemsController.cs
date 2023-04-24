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
    public class WishlistItemsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public WishlistItemsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/WishlistItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WishlistItem>>> GetWishlistItems()
        {
            return await _context.WishlistItems.ToListAsync();
        }

        // GET: api/WishlistItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WishlistItem>> GetWishlistItem(int id)
        {
            var wishlistItem = await _context.WishlistItems.FindAsync(id);

            if (wishlistItem == null)
            {
                return NotFound();
            }

            return wishlistItem;
        }

        // PUT: api/WishlistItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWishlistItem(int id, WishlistItem wishlistItem)
        {
            if (id != wishlistItem.WishlistItemID)
            {
                return BadRequest();
            }

            _context.Entry(wishlistItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WishlistItemExists(id))
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

        // POST: api/WishlistItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WishlistItem>> PostWishlistItem(WishlistItem wishlistItem)
        {
            _context.WishlistItems.Add(wishlistItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWishlistItem", new { id = wishlistItem.WishlistItemID }, wishlistItem);
        }

        // DELETE: api/WishlistItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWishlistItem(int id)
        {
            var wishlistItem = await _context.WishlistItems.FindAsync(id);
            if (wishlistItem == null)
            {
                return NotFound();
            }

            _context.WishlistItems.Remove(wishlistItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WishlistItemExists(int id)
        {
            return _context.WishlistItems.Any(e => e.WishlistItemID == id);
        }
    }
}
