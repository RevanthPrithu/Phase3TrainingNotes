using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program16
    {
        /*static void Display()
        {
            Console.WriteLine("Hello from methods");
        }
            static void DrawLine()
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("=");
                Console.WriteLine();

            }
        static void Main(string[] args)
        {
            DrawLine();
            Display();
            DrawLine();
        }
        
        static void Wishes(string name)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
                Console.WriteLine($"Hello{name} Good Morning");
            else if (hour < 16) Console.WriteLine($"Hello {name}, Good Afternoon!");
            else Console.WriteLine($"Hello {name}, Good Evening!");
        }
        static void Main(string[] args)
        {
            Wishes("Sangeetha!");
        }
    */
        /*  static void Display( int a , int b)
          {
              Console.WriteLine($"a ={a} ,b={b}");
          }
          static void Square(ref int a, ref int b)
          {
              a *= a;       b *= b;


          }
          static void Swap(ref int a,ref int b)
          {
              int c;
              c = a;
              a = b;
              b = c;
              Console.WriteLine($"a is {a} and b is {b}");

          }
          static void Main(string[] args)
          {
              int a = 100; int b = 200;
              Console.WriteLine("Before Square");
              Display(a, b);
              Square(ref a, ref b);
              Console.WriteLine("AfterSquare");
              Display(a, b);
              Swap(ref a, ref b);



          }

         /* static void initialize(out int a)
          {
              a = 0;
          }
          static void Main(string[] args)
          {
              int a;
              initialize(out a);
              Console.WriteLine(a);
          }

          */

        static void GetRole(string qualification,out string eligibleRole)
        {
            switch(qualification)
            {
                case "B.Tech":
                    eligibleRole = "Programmer";
                    break;
                case "MBA":
                    eligibleRole = "Hr";
                    break;
                case "MCA":
                    eligibleRole = "TRAINER";
                    break;
                default:
                    eligibleRole = "Assistant";
                    break;


            }


        }
        static void Main(string[] args)
        {
            string qualification = "B.Tech";
            string eligibleRole;
            GetRole(qualification, out eligibleRole);
            Console.WriteLine($" For Qualification {qualification} eligible role is {eligibleRole}");
        }



    }
}
/*
 * A method is a function inside a class
A method is a self contained block of statement to perform a task
A method can return a value to the caller
Methdo can be be defined as 
a) static    :    These methods will be called directly
b) regular: These methods will be called using object
*/