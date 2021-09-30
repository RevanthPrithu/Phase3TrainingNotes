using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program29
    {
        static void Main(string[] args)
        {
            //action

            /*
            Action display = delegate ()//delegate is lamda expression and action encapsulates a method that has no parameters or return type
            {
                Console.WriteLine("hello from display");
            };
            Action<string> wishes = delegate (string name)
              {
                  Console.WriteLine($"hello {name}");
              };
            display();
            wishes("revanth");
           


            // func<T,T>

            Func<int, int> square = delegate (int n)
               {
                   return n * n;
               };
            Func<int, int> next = delegate (int n)
            {
                return n+1;
            };
            Console.WriteLine(square(5));
            Console.WriteLine(next(8));
             */

            //predicate
            Predicate<int> isZero = delegate (int n)
              {
                  if (n == 0)
                      return true;
                  else
                      return false;
              };
            Predicate<int> isPositive = delegate (int n)
            {
                if (n>0)
                    return true;
                else
                    return false;
            };

            int n = -6;
            if(isZero(n))
                Console.WriteLine("Input is zero");
            else if (isPositive(n))
                Console.WriteLine($"{n} is positive");
            else
                Console.WriteLine($"{n} is negative");



        }
    }
}
/*Delegate:    A delegate is a typesafe function pointer
The object of delegate can be referred to a function or set of functions
.net provided 3 inbuilt delegates
Action    :    Refers to a function perform a task and without returning value
Func    :    Refers to a function  return a value
Predicate:    Refers to a function return boolean value
*/
