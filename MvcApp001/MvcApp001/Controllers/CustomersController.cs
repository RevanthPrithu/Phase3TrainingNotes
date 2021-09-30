using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcApp001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Controllers
{
   
    public class CustomersController : Controller
    {
        CustomerBO context = new CustomerBO();

        // GET: CustomersController
        public ActionResult Index()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            customers = context.GetAllCustomers();
            
            return View(customers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            CustomerModel c = context.GetCustomerById(id);
            return View(c);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        public ActionResult Create(CustomerModel c)
        {
            try
            {
                context.AddCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.GetCustomerById(id));
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel c)
        {
            try
            {
                context.EditCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.GetCustomerById(id));
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel c)
        {
            try
            {
                context.DeleteCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
