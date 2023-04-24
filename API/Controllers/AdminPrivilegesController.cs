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
    public class AdminPrivilegesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public AdminPrivilegesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/AdminPrivileges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminPrivileges>>> GetAdminPrivileges()
        {
            return await _context.AdminPrivileges.ToListAsync();
        }

        // GET: api/AdminPrivileges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminPrivileges>> GetAdminPrivileges(int id)
        {
            var adminPrivileges = await _context.AdminPrivileges.FindAsync(id);

            if (adminPrivileges == null)
            {
                return NotFound();
            }

            return adminPrivileges;
        }

        // PUT: api/AdminPrivileges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminPrivileges(int id, AdminPrivileges adminPrivileges)
        {
            if (id != adminPrivileges.AdminPrivilegesID)
            {
                return BadRequest();
            }

            _context.Entry(adminPrivileges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminPrivilegesExists(id))
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

        // POST: api/AdminPrivileges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdminPrivileges>> PostAdminPrivileges(AdminPrivileges adminPrivileges)
        {
            _context.AdminPrivileges.Add(adminPrivileges);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminPrivileges", new { id = adminPrivileges.AdminPrivilegesID }, adminPrivileges);
        }

        // DELETE: api/AdminPrivileges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminPrivileges(int id)
        {
            var adminPrivileges = await _context.AdminPrivileges.FindAsync(id);
            if (adminPrivileges == null)
            {
                return NotFound();
            }

            _context.AdminPrivileges.Remove(adminPrivileges);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminPrivilegesExists(int id)
        {
            return _context.AdminPrivileges.Any(e => e.AdminPrivilegesID == id);
        }
    }
}
