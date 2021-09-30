using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value:");
            int d = Convert.ToInt32(Console.ReadLine());

            switch(d)
            {
                case 1:
                    Console.WriteLine("North");
                    break;
                case 2:
                    Console.WriteLine("EAST");
                    break;

                case 3:
                    Console.WriteLine("WEST");
                    break;

                case 4:
                    Console.WriteLine("SOUTH");
                    break;
                default:
                    Console.WriteLine("Inavlid choice");
                    break;



            }

        }
    }
}
