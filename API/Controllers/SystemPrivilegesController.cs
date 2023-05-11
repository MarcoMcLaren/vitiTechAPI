﻿using System;
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
    public class SystemPrivilegesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public SystemPrivilegesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/SystemPrivileges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SystemPrivilege>>> GetSystemPrivileges()
        {
            return await _context.SystemPrivileges.ToListAsync();
        }

        // GET: api/SystemPrivileges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SystemPrivilege>> GetSystemPrivilege(int id)
        {
            var systemPrivilege = await _context.SystemPrivileges.FindAsync(id);

            if (systemPrivilege == null)
            {
                return NotFound();
            }

            return systemPrivilege;
        }

        // PUT: api/SystemPrivileges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystemPrivilege(int id, SystemPrivilege systemPrivilege)
        {
            if (id != systemPrivilege.SystemPrivilegeID)
            {
                return BadRequest();
            }

            _context.Entry(systemPrivilege).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemPrivilegeExists(id))
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

        // POST: api/SystemPrivileges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SystemPrivilege>> PostSystemPrivilege(SystemPrivilege systemPrivilege)
        {
            _context.SystemPrivileges.Add(systemPrivilege);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SystemPrivilegeExists(systemPrivilege.SystemPrivilegeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSystemPrivilege", new { id = systemPrivilege.SystemPrivilegeID }, systemPrivilege);
        }

        // DELETE: api/SystemPrivileges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystemPrivilege(int id)
        {
            var systemPrivilege = await _context.SystemPrivileges.FindAsync(id);
            if (systemPrivilege == null)
            {
                return NotFound();
            }

            _context.SystemPrivileges.Remove(systemPrivilege);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SystemPrivilegeExists(int id)
        {
            return _context.SystemPrivileges.Any(e => e.SystemPrivilegeID == id);
        }
    }
}
