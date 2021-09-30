using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class program33
    {
        static void Main(string[] args)
        {
            /*  EmployeeBO  context = new EmployeeBO();
              List<Empmode1> employees = context.GetAllEmployees();
              foreach(Empmode1 e in employees)
                  Console.WriteLine($"{e.Id}{e.EName}{e.Job}{e.Salary}");
            */
            EmployeeBO context = new EmployeeBO();
            List<Empmode1> employees;
            employees = context.GetAllEmployees();
            employees = context.GetAllEmployees().Skip(3).ToList();
            employees = context.GetAllEmployees().Where(x => x.Job == "Trainer2").ToList();
                foreach(Empmode1 e in employees)
                Console.WriteLine($"{e.Id}{e.EName}{e.Job}{e.Salary}");


        }
    }
}
