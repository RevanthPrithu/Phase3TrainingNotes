using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program2
    {
        //Read full name into a variable and display fullname, lastname in seperate output
        static void Main(string[] args)
        {
            Console.WriteLine("second program class");
            Console.Write("Enter your name");
            string fullname = Console.ReadLine();
            string firstname = fullname.Substring(0, fullname.IndexOf(" "));
            string lastname = fullname.Substring(fullname.LastIndexOf(" ")+1);
            Console.WriteLine($"hello{fullname}");
            Console.WriteLine($"first name is :{firstname}");
            Console.WriteLine($"last name is :{lastname}");




        }
    }
}
/*
 * naming convention:while writing programmable code,have to follow naming 
 * ClassName, MethodName or any TypeName should be in PascalCase
keywords will be in lower case
containts will be in UPPER CASE
variable names will be camelCaseNotation
*/