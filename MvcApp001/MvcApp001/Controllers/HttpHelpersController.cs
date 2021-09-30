using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
    public class HttpHelpersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.msg = "Hello ! Welcome";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string t1)
        {
            ViewBag.msg = $"Hello {t1}! Welcome back";
            return View();
        }
    }
}
