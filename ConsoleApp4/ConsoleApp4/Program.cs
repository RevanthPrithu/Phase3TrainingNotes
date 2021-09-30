using System;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string cs = "server=(local);integrated security=true;database=revanthdb";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            Console.WriteLine("Sql DB Connection established successfully...");
           
        }
    }
}
/*
* ADO.NET: ActiveX Database Objects
* It is an API containing classes used to interact with database and perform operations into it

* System.Data.SqlClient:   This library to be installed using nuget packages
* 
* SqlConnection:   This class contains methods like Open(), Close()
* Open():  USed to establish DB Connection
* Close(): Used to close the established connection
* 
* connection string:   Refers to credentials for database to be connected

*/
