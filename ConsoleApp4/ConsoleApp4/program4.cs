using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp4
{
    class program4
    {
        static void Main(string[] args)
        {
            string cs = string.Empty;
            string query = string.Empty;

            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            cs = "server=(local);integrated security=true;database=revanthdb";
            cn = new SqlConnection(cs);
            cn.Open();
            query = "spGetAllEmployees";
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} ");

            }
        }
    }
}
/*
 * CommandType.StoredProcedure: This is an enum type to specify query type is stored procedure
 * This is available by providing namespace System.Data
 */