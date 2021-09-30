using System;

namespace RepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository empContext = null;
            //empContext = new OracleEmployeeRepository();
            empContext = new MySqlEmployeeRepository();
            foreach (EmpModel e in empContext.GetAllEmployees())
                Console.WriteLine($"{e.Id} {e.EName } {e.Job} {e.Salary}");
        }
    }
}
