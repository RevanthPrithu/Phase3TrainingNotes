using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("third program class");
            Console.Write("Enter a letter:");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Given letter is :{ch}");
            Console.WriteLine($"next letter of {ch} is :{(char)(ch+1)}");
            Console.WriteLine($"previous letter of {ch} is :{(char)(ch -1)}");

            //using ASCII
            Console.Write("Enter a letter:");
            char chr = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Given letter is {chr}");
            if (chr >= 65 && chr <= 90)
                Console.WriteLine($"{chr} is a capital letter");
            else if (chr >= 97 && chr <= 122)
                Console.WriteLine($"{chr} is a small letter");
            else if (chr >= 48 && chr <= 57)
                Console.WriteLine($"{chr} is a digit");
            else Console.WriteLine($"{chr} is a special letter");

        }
    }
}
/*
 character refers to any letter including alphabet, digit, special letters
  ASCII value for every letter
A - Z   are 65 to 90
a - z are 97 to 122
0 - 9  are 48 to 57 
 */
