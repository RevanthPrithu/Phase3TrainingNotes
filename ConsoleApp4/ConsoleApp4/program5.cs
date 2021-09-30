using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp4
{
    class program5
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
            Console.Write("Enter value for employee id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            query = "select * from tblEmployees where id=@id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();
            if (dr.Read())
                Console.WriteLine($"{dr[0].ToString()} {dr[1].ToString()} {dr[2].ToString()} {dr[3].ToString()} {dr[4].ToString()} ");
            else
                Console.WriteLine($"{id} not available...");
        }
    }
}
