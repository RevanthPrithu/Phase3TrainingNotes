using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcApp001.Models;


namespace MvcApp001.Controllers
{
    public class PeopleController : Controller
    {
        static List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{Id=1001,PName=" ANil",Gender="Male",Age=25},
                 new PersonModel{Id=1002,PName=" rev",Gender="Male",Age=55},
                  new PersonModel{Id=1003,PName=" revs",Gender="Male",Age=35}
            };
        public IActionResult Index()
        {
            ViewBag.people = people;
            
            return View();
        }
        public IActionResult Details(int id)
        {
            PersonModel p = people.Single(x=>x.Id==id);

            ViewBag.p = p;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id,string pname,string gender,int age)
        {
            PersonModel p = new PersonModel()
            {
                Id = id,
                PName = pname,
                Gender = gender,
                Age = age
            };
            people.Add(p);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.p = people.Single(x => x.Id == id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, string pname, string gender, int age)
        {
            PersonModel p = new PersonModel()
            {
                Id = id,
                PName = pname,
                Gender = gender,
                Age = age
            };
            int index = people.FindIndex(x => x.Id == id);
            people[index] = p;
        

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            PersonModel p = people.Single(x => x.Id == id);

            ViewBag.p = p;
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id, string pname, string gender, int age)
        {
            PersonModel p = new PersonModel()
            {
                Id = id,
                PName = pname,
                Gender = gender,
                Age = age
            };
            int index = people.FindIndex(x => x.Id == id);
            people.RemoveAt(index);


            return RedirectToAction("Index");
        }
    }
}
