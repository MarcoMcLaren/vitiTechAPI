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
    public class BookingPaymentsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public BookingPaymentsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/BookingPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingPayment>>> GetBookingPayments()
        {
            return await _context.BookingPayments.ToListAsync();
        }

        // GET: api/BookingPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingPayment>> GetBookingPayment(int id)
        {
            var bookingPayment = await _context.BookingPayments.FindAsync(id);

            if (bookingPayment == null)
            {
                return NotFound();
            }

            return bookingPayment;
        }

        // PUT: api/BookingPayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingPayment(int id, BookingPayment bookingPayment)
        {
            if (id != bookingPayment.PaymentID)
            {
                return BadRequest();
            }

            _context.Entry(bookingPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingPaymentExists(id))
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

        // POST: api/BookingPayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingPayment>> PostBookingPayment(BookingPayment bookingPayment)
        {
            _context.BookingPayments.Add(bookingPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookingPayment", new { id = bookingPayment.PaymentID }, bookingPayment);
        }

        // DELETE: api/BookingPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingPayment(int id)
        {
            var bookingPayment = await _context.BookingPayments.FindAsync(id);
            if (bookingPayment == null)
            {
                return NotFound();
            }

            _context.BookingPayments.Remove(bookingPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingPaymentExists(int id)
        {
            return _context.BookingPayments.Any(e => e.PaymentID == id);
        }
    }
}
