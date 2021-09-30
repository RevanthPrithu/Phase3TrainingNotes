using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    class MySqlEmployeeRepository: IEmployeeRepository
    {
        public IEnumerable<EmpModel> GetAllEmployees()
        {
            return new List<EmpModel> {
                new EmpModel{Id=3001,EName="Mohan",Job="Trainer",Salary=12000},
                new EmpModel{Id=3002,EName="Murthy",Job="Programmer",Salary=22000}

            };
        }
    }
}
