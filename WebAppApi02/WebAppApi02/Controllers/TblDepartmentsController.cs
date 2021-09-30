using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppApi02.Model;

namespace WebAppApi02.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TblDepartmentsController : ControllerBase
    {
        private readonly revanthdbContext _context;

        public TblDepartmentsController(revanthdbContext context)
        {
            _context = context;
        }

        // GET: api/TblDepartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblDepartment>>> GetTblDepartments()
        {
            return await _context.TblDepartments.ToListAsync();
        }

        // GET: api/TblDepartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblDepartment>> GetTblDepartment(int id)
        {
            var tblDepartment = await _context.TblDepartments.FindAsync(id);

            if (tblDepartment == null)
            {
                return NotFound();
            }

            return tblDepartment;
        }

        // PUT: api/TblDepartments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblDepartment(int id, TblDepartment tblDepartment)
        {
            if (id != tblDepartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblDepartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblDepartmentExists(id))
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

        // POST: api/TblDepartments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblDepartment>> PostTblDepartment(TblDepartment tblDepartment)
        {
            _context.TblDepartments.Add(tblDepartment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblDepartmentExists(tblDepartment.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblDepartment", new { id = tblDepartment.Id }, tblDepartment);
        }

        // DELETE: api/TblDepartments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblDepartment>> DeleteTblDepartment(int id)
        {
            var tblDepartment = await _context.TblDepartments.FindAsync(id);
            if (tblDepartment == null)
            {
                return NotFound();
            }

            _context.TblDepartments.Remove(tblDepartment);
            await _context.SaveChangesAsync();

            return tblDepartment;
        }

        private bool TblDepartmentExists(int id)
        {
            return _context.TblDepartments.Any(e => e.Id == id);
        }
    }
}
