using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp4
{
    class program2
    {
        static void Main(string[] args)
        {
            string cs = string.Empty;
            SqlConnection cn = null;
            cs = "server=(local);integrated security=true;database=revanthdb";

            try
            {
                cn = new SqlConnection(cs);
                cn.Open();
                Console.WriteLine("Sql DB Connection established successfully...");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("DB Connection error " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
                Console.WriteLine("Connection closed successfully...");
            }
        }
    }
}
