using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program17
    {
       /* static void DisplayNames(params string[] names)
        {
            Console.WriteLine("Given names are:");
            for (int i = 0; i < names.Length; i++)
                Console.Write($"{names[i]}  ");
            Console.WriteLine("\n======================================");
           

        }
        static void Main(string[] args)
        {
            DisplayNames("rev", "ranj", "poor");
            DisplayNames("sach", "kesh");
        }
       */
       //INCLUDING ANOTHER PARAMETER

        static void DisplayNames(string batchcode ,params string[] names)
        {
            Console.WriteLine("Given names are:");
            Console.Write($"batch code is {batchcode}:");
            for (int i = 0; i < names.Length; i++)
            Console.Write($"{names[i]}  ");
            Console.WriteLine("\n======================================");


        }
        static void Main(string[] args)
        {
            DisplayNames("01","rev", "ranj", "poor");
            DisplayNames("02","sach", "kesh");
        }
    }
}
