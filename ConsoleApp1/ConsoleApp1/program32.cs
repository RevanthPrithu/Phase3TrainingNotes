using System;
using System.Collections.Generic;
using System.Text;
//POCO CLASS
namespace ConsoleApp1
{
    class program32
    {
        static void Main(string[] args)
        {
            /*
            Empmode1 e1 = new Empmode1 { Id = 1001, EName = "Rev", Job = "Trainer", Salary = 5000 };
            Empmode1 e2 = new Empmode1 { Id = 1002, EName = "Reva", Job = "Trainer2", Salary = 6000 };
            Empmode1 e3 = new Empmode1 { Id = 1003, EName = "Revs", Job = "Trainer3", Salary = 7000 };
            Empmode1 e4 = new Empmode1 { Id = 1004, EName = "Revanth", Job = "Trainer4", Salary = 8000 };
            Empmode1 e5 = new Empmode1 { Id = 1004, EName = "Revathi", Job = "Trainer5", Salary = 9000 };

            Console.WriteLine($" {e1.Id} {e1.EName} {e1.Job} {e1.Salary}");
            Console.WriteLine($"{e2.Id} {e2.EName}  {e2.Job} {e2.Salary}");
            Console.WriteLine($"{e3.Id} {e3.EName}  {e3.Job} {e3.Salary}");
            Console.WriteLine($"{e4.Id} {e4.EName}  {e4.Job} {e4.Salary}");
            Console.WriteLine($"{e5.Id} {e5.EName} {e5.Job} {e5.Salary}");
           */
            List<Empmode1> employees = new List<Empmode1>();


            employees.Add(new Empmode1 { Id = 1001, EName = "Rev", Job = "Trainer", Salary = 5000 });
            employees.Add(new Empmode1 { Id = 1002, EName = "Reva", Job = "Trainer2", Salary = 6000 });
            employees.Add(new Empmode1 { Id = 1003, EName = "Revs", Job = "Trainer3", Salary = 7000 });
            employees.Add(new Empmode1 { Id = 1004, EName = "Revanth", Job = "Trainer4", Salary = 8000 });
            employees.Add(new Empmode1 { Id = 1004, EName = "Revathi", Job = "Trainer5", Salary = 9000 });
            /*employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);
            */
            foreach(Empmode1 e in employees)
                Console.WriteLine($"{e.Id}{e.EName}{e.Job}{e.Salary}");

        }
    }

}

