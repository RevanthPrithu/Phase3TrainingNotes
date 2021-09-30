using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program27
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "banana", "cherry", "apple", "mango" };
            foreach(string fruit in fruits)
                Console.WriteLine(fruit);



            List<int> items = new List<int> { 10, 20, 30, 40 };
            items.Insert(0, 5);
            items.Add(40);
            foreach (int item in items)
                Console.WriteLine(item);

        }
    }
}
/*
 * generic used to restrict datatype in the collection\
 * */