using System.Collections.Generic;

namespace RepositoryExample
{
    internal interface IEmployeeRepository
    {
        IEnumerable<EmpModel> GetAllEmployees();
    }
}