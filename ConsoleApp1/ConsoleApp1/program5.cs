using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fifth program class");
            Console.Write("Enter value for lmr:");
            int lmr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for pmr:");
            int pmr = Convert.ToInt32(Console.ReadLine());
            int bu = pmr - lmr;
            Console.WriteLine($"Billed units:{bu}");

            double ur = 0;
            if (bu < 150) ur = 1.75;
            else if (bu < 375) ur = 1.75;
            else if (bu < 500) ur = 3.25;
            else ur = 6.5;
            Console.WriteLine($"Unit rate is:{ur}");
            double amount = bu * ur;
            Console.WriteLine($"Amount is :{amount}");





        }
    }
}
/*
 * Task: Generate electricity bill
 * input :lmr,pmr
 * calculate :bu=pmr-lmr
 * calculate ur
 * bu                ur
 * <150             1.75
 * <375             3.35
 * <500             5
 * >=500             6.5
 * calculate amount and display
 */
