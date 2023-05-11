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
    public class EventReviewsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public EventReviewsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/EventReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventReview>>> GetEventReviews()
        {
            return await _context.EventReviews.ToListAsync();
        }

        // GET: api/EventReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventReview>> GetEventReview(int id)
        {
            var eventReview = await _context.EventReviews.FindAsync(id);

            if (eventReview == null)
            {
                return NotFound();
            }

            return eventReview;
        }

        // PUT: api/EventReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventReview(int id, EventReview eventReview)
        {
            if (id != eventReview.EventReviewID)
            {
                return BadRequest();
            }

            _context.Entry(eventReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventReviewExists(id))
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

        // POST: api/EventReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventReview>> PostEventReview(EventReview eventReview)
        {
            _context.EventReviews.Add(eventReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventReview", new { id = eventReview.EventReviewID }, eventReview);
        }

        // DELETE: api/EventReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventReview(int id)
        {
            var eventReview = await _context.EventReviews.FindAsync(id);
            if (eventReview == null)
            {
                return NotFound();
            }

            _context.EventReviews.Remove(eventReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventReviewExists(int id)
        {
            return _context.EventReviews.Any(e => e.EventReviewID == id);
        }
    }
}
