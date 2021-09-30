using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
    public class PostbackdemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Get Call,first request";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id)
        {
            ViewBag.msg = "Post call repeated request";
            return View();
        }
        public IActionResult Ex01(string b1)
        {
            ViewBag.msg = b1+" clicked !";
            return View();
        }
        public IActionResult Ex02(string t1)
        {
            ViewBag.msg = $"Hello{t1}";
            return View();
        }

    }
}
