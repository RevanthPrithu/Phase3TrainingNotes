using System.Collections.Generic;

namespace ConsoleApp1
{
    class EmployeeBO
    {
        public List<Empmode1> employees { get; set; }
        public EmployeeBO()
        {
            employees = new List<Empmode1>()
            {

             new Empmode1 { Id = 1001, EName = "Rev", Job = "Trainer1", Salary = 5000 },
             new Empmode1 { Id = 1002, EName = "Reva", Job = "Trainer2", Salary = 6000 },
             new Empmode1 { Id = 1003, EName = "Revs", Job = "Trainer3", Salary = 7000 },
             new Empmode1 { Id = 1004, EName = "Revanth", Job = "Trainer4", Salary = 8000 },
             new Empmode1 { Id = 1004, EName = "Revathi", Job = "Trainer5", Salary = 9000 },
             new Empmode1 { Id = 1001, EName = "Revuuuuu", Job = "Trainer6", Salary = 5000 },
             new Empmode1 { Id = 1002, EName = "Revaaaaaaa", Job = "Trainer7", Salary = 6000 },
             new Empmode1 { Id = 1003, EName = "Revssssssss", Job = "Trainer8", Salary = 7000 },
             new Empmode1 { Id = 1004, EName = "Revanthhhhhhhhhhh", Job = "Trainer9", Salary = 8000 },
             new Empmode1 { Id = 1004, EName = "Revathiiiiiiiiii", Job = "Trainer10", Salary = 9000 }
        };
            
        }
        /*public List<Empmode1> GetAllEmployees()
        {
            return employees;
        }
        */
        //or
        //expression body method
        public List<Empmode1> GetAllEmployees() => employees;
    }
}
