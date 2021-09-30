using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
    public class PassingDataDemoControllerController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "Revanth";
            ViewData["technology"] = ".Net";
            return View();
        }
        public IActionResult Ex01()
        {
            string[] fruits = { "Apple", "banana", "cherry", "grapes" };
            List<string> cakes = new List<string> { "Pineapple", "strawbwerry", "custard" };
            ViewBag.fruits = fruits;
            ViewBag.cakes = cakes;
            return View();
        }
    }
}
