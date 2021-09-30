using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp4
{
    class program3
    {
        static void Main(string[] args)
        {
            string cs = "server=(local);integrated security=true;database=revanthdb";
            SqlConnection cn =  new SqlConnection(cs);
            cn.Open();
            string query = "select * from tblDepartments";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()}");
            }
            Console.WriteLine("Sql server established successfully");
        }
    }
}
/* 
 * SqlCommand class contains following methods to performs database table operations
 * ExecuteReader()  :   Used to issue select statement return records
 * ExecuteScalar()  :   Used to issue select statement return single value
 * ExecuteNonQuery():   Used to issue any command other than select
 
    SqlDataReader:  The object of this class can refer to result returned by ExecuteReader() method
    This class contains Read() method which read each row and forward cursor to next row
 */