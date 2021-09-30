using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program30
    {
        // linq queries:provided in built extension methods
        static void Main(string[] args)
        {
            //List<string> fruits = new List<string> { "banana", "cherry", "apple", "mango" };
            /* Console.WriteLine(fruits.First());
             Console.WriteLine(fruits.Last());
             Console.WriteLine(fruits.ElementAt(2));
             Console.WriteLine(fruits.Count());
            */
            // foreach(string fruit in fruits.Take(4))
           // foreach(string fruit in fruits.Skip(2)) //first 2 fruits skipped
               // foreach (string fruit in fruits.Skip(1).Take(2))//skip first fruit and take next 2 fruits only (ignoring mango)
                   // Console.WriteLine(fruit);

            List<int> items = new List<int> { 10, 20, 30, 40,56,67,78,89,90,09,98,87,76,65,54,43,32,21 };
            /*Console.WriteLine(items.First());
            Console.WriteLine(items.Last());
            Console.WriteLine(items.ElementAt(2));
            Console.WriteLine(items.Count());
            Console.WriteLine(items.Max());
            Console.WriteLine(items.Min());
            Console.WriteLine(items.Average());
            */
           // foreach (int item in items)
           // foreach (int item in items.Take(4))
                // foreach(int item in items.Skip(2)) 
                foreach (int item in items.Take(10).Skip(2).Take(3))
                Console.WriteLine(item);

        }
    }
}
