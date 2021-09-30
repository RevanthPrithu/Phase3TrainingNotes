using EfCoreApp02.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp02.Controllers
{
    public class EmployeesController : Controller
    {
        revanthdbContext context = new revanthdbContext();

        public IActionResult Index()
        {
            return View(context.TblEmployees);
        }
        public IActionResult Details(int id)
        {
            return View(context.TblEmployees.Single(x => x.Id == id));
        }
    }
}
