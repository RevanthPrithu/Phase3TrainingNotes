﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
    public class RazorDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ex01()
        {
            return View();
        }
        public IActionResult Ex02()
        {
            return View();
        }

        public IActionResult Ex03()
        {
            return View();
        }



    }
}
