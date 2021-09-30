using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine($"{i} {11 - i}");
                Thread.Sleep(1000);
                i++;
            }
            //Generate fibnocci series
            int a = 0, b = 1;
            int c = 0;
            Console.Write($"{a} {b} ");
            int d = 2;
            while(d<10)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                d++;
            }
            //generating multiplication table
            Console.Write("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int e = 1;
            while (e <= 10)
            {
                Console.WriteLine($"{num} X {e} = {num * e}");
                e++;
            }
            //using for loop
            Console.Write("Enter a number");
            int numfor = Convert.ToInt32(Console.ReadLine());
            for (int f = 1; f <= 10; f++)
                Console.WriteLine($"{numfor} X {f} = {numfor * f}");

        }
    }
}
