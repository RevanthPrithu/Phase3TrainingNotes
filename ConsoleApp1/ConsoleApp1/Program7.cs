using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main(string[] args)
        {
            var v1 = 100;//we can specify any datatype here using var
            Console.WriteLine($"v1={v1},datatype is {v1.GetType()}");
            var v2 = 10.80;//we can specify any datatype here using var
            Console.WriteLine($"v2={v2},datatype is {v2.GetType()}");
            var v3 = 'a';//we can specify any datatype here using var
            Console.WriteLine($"v3={v3},datatype is {v3.GetType()}");
            var v4 = true;//we can specify any datatype here using var
            Console.WriteLine($"v4={v4},datatype is {v4.GetType()}");
            var v5 = "revu";//we can specify any datatype here using var
            Console.WriteLine($"v5={v5},datatype is {v5.GetType()}");

        }
    }
}
/*
 var type used to provide datatype based on value supplied
    variable with var type should not be empty, it assign value at complile time
 */
