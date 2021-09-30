using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryExample
{
    class OracleEmployeeRepository:IEmployeeRepository
    {
        public IEnumerable<EmpModel> GetAllEmployees()
        {
            return new List<EmpModel> {
                new EmpModel{Id=2001,EName="Omkar",Job="Trainer",Salary=12000},
                new EmpModel{Id=2002,EName="Oven",Job="Programmer",Salary=22000},
                new EmpModel{Id=2003,EName="Orange",Job="Programmer",Salary=22000},
                new EmpModel{Id=2004    ,EName="Om",Job="Trainer",Salary=21000}
            };
        }

    }
}
