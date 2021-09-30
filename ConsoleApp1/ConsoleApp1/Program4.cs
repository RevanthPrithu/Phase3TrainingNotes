using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fourth program class");
            Console.Write("Enter no:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                Console.WriteLine("input is zero");
            else
                Console.WriteLine($"{number} is not zero");
            //logical operators in use
            Console.Write("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks>=35 && marks<= 100)
                Console.WriteLine("input {marks} is valid");
            else
                Console.WriteLine($"{marks} not valid");
            //Read 3 sub marks into vm,p,c variables and display total,avg,result and grade
            Console.Write("Enter sub1(maths) marks:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub1(physics) marks:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub1(chemistry) marks:");
            int c = Convert.ToInt32(Console.ReadLine());
            int total = m + p + c;
            double avg = (double)total / 3;
            Console.WriteLine($"total marks:{total}");
            Console.WriteLine($"Average marks:{avg}");

            string result = string.Empty; string grade = string.Empty;
            if(m>=35 && p>=35 && c>=35)
            {
                result = "pass";
                if (avg >= 75) grade = "A+";
                else if (avg >= 60) grade = "A";
                else if (avg >= 50) grade = "B";
                else grade = "C";

            }
            else
            {
                result = "FAIL";
                grade = "NA";

            }
            Console.WriteLine($"Result is :{result},Grade is :{grade}");







        }
    }
}
/*
 * Control structure:used to control statement execution
 * if: used as branching
 * case:used for constant expression in the condition
 * loop:to iterate statements
 * relational operators :>,>=.<,<=,==,!=
 * logical operators :&&.||,!
 */
