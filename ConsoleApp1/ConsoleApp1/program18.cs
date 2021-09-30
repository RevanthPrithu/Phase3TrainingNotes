using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program18
    {
        //OVERLOADING FUNCTION
        /*static void Display()
        {
            Console.WriteLine("Hello GM");

        }
        static void Display(string name)
        {
            Console.WriteLine($"hello {name} GM");
        }
        static void Main(string[] args)
        {
            Display();
            Display("RevanthM");
        }
        */
        static int Square(int n)
        {
            return n * n;
        }
        static int Addition(int a , int b)
        {
            return a+b;
        }
        static int Biggest(int c, int d)
        {
            if (c > d)
            {
                return c;
            }
            else return d;

        }
        static int Smallest(int c, int d)
        {
            if (c < d)
            {
                return c;
            }
            else return d;
            //return a>b?a:b

        }
       /* static int reverse(int c)
        {
            int rev = 0;

        }
        static int factorial(int n)
        {

        }
       */
        static void Main(string[] args)
        {
            Console.WriteLine(Square(6));
            Console.WriteLine(Biggest(6,3));
            Console.WriteLine(Smallest(6,3));
           /* Console.WriteLine(reverse(645));
            Console.WriteLine(factorial(6));
           */

        }
    }
}
