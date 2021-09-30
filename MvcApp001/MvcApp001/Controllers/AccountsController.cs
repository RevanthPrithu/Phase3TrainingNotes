using Microsoft.AspNetCore.Mvc;
using MvcApp001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        private bool ValidateUser(string uname,string pwd)
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel{UserName="revanth",Password="Prithu"},
                new UserModel{UserName="revanth",Password="Prithu"},
                new UserModel{UserName="revanth",Password="Prithu"},
                new UserModel{UserName="revanth",Password="Prithu"},
            };
            return users.Exists(x => x.UserName == uname && x.Password == pwd);
        }
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if (ValidateUser(user.UserName, user.Password))
            {
                return RedirectToAction("dashboard", "Accounts", new { uname = user.UserName });
            }
            else
                ViewBag.msg = "Invalid input credentials...";
            return View();
        }
        public IActionResult dashboard(string uname)
        {
            ViewBag.msg = $"Hello{uname},welcome to dashboard";
            return View();
        }
    }
}
