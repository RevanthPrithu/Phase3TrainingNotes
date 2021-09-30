using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi02.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppApi02.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        revanthdbContext context = new revanthdbContext();
        [HttpGet]
        public IEnumerable<TblEmployee> Get()
        {
            return context.TblEmployees.ToList();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public TblEmployee Get(int id)
        {
            return context.TblEmployees.Single(x => x.Id == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] TblEmployee e)
        {
            context.TblEmployees.Add(e);
            context.SaveChanges();
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TblEmployee e)
        {
            context.TblEmployees.Update(e);
            context.SaveChanges();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.TblEmployees.Remove(context.TblEmployees.Single(x => x.Id == id));
            context.SaveChanges();
        }
    }
}
