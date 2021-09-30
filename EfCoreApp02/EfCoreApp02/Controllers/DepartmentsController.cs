using EfCoreApp02.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreApp02.Controllers
{
    public class DepartmentsController : Controller
    {
        revanthdbContext context = new revanthdbContext();
        public IActionResult Index()
        {
            return View(context.TblDepartments);
        }
        public IActionResult Details(int id)
        {
            return View(context.TblDepartments.Single(x => x.Id == id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TblDepartment d)
        {
            return View();
        }
    }
}
