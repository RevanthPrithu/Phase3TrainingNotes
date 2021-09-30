using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program20
    {
        static void Main(string[] args)
        {
            string[] names = { "rev", "reva", "raj", "nir" };
            foreach (string name in names)
                Console.WriteLine(name);
            int[] items = { 100, 200, 300, 400, 500 };
            foreach (int item in items)
                Console.WriteLine(item);
        }
    }
}
