using Microsoft.AspNetCore.Mvc;
using RpMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpMVCApp.Controllers
{
    public class StudentsController : Controller
    {
       static IEnumerable<IStudentRepository> _repositories = null;
       static IStudentRepository _repository = null;
        public StudentsController(IEnumerable<IStudentRepository>repositories)
        {
            _repositories = repositories;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(string b1)
        {
            if (b1 == "mysqlserver")
                _repository = _repositories.Single(x => x.GetSourceInfo() == "mysqlserver");
            else if (b1=="sqlserver")
                _repository = _repositories.Single(x => x.GetSourceInfo() == "sqlserver");
            ViewBag.msg = _repository.GetSourceInfo();
            return RedirectToAction("List");
        }
      public IActionResult List()
        {
            ViewBag.heading = " Source from " + _repository.GetSourceInfo();
            IEnumerable<StudentModel> students = _repository.GetAllStudents();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            ViewBag.heading = "Source from " + _repository.GetSourceInfo();
            StudentModel s = _repository.GetStudentById(id);
            return View(s);
        }
    }
}
