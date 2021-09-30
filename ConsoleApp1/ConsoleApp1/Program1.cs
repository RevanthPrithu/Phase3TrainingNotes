using System;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();//to wait output until press any key
            Console.WriteLine("HI Revanth");
            string name;//declare string variable
            name = "revanth m";
            Console.WriteLine(name);//display variable content
            Console.WriteLine($"This is {name}");//templating literals :provide variable content within message
            string stuname = "REVANTH_M";//STRING INITIALIZATION
            Console.WriteLine($"Hello{stuname}");
            Console.WriteLine($"Length is{stuname.Length}");
            Console.WriteLine($"UPPER CASE IS{stuname.ToUpper()}");//convert to upper case
            Console.WriteLine($"lower case is {stuname.ToLower()}");//convert to lower case
            Console.WriteLine($"{stuname.IndexOf("A")}");//return first index of a
            Console.WriteLine($"{stuname.LastIndexOf("A")}");//return last occurance of a
            Console.WriteLine($"{stuname.Substring(0,3)}");//return first three letters of stuname
            Console.WriteLine($"{stuname.Substring(4,5)}");//return 6 letters from fourth position
            string fullname = "Revanth Gowda M";
            //display fullname excluding first letter
            Console.WriteLine(fullname.Substring(1));
            //display full name excluding last letter
            Console.WriteLine(fullname.Substring(0, fullname.Length - 1));
            //display first name in full name
            Console.WriteLine(fullname.Substring(0, fullname.IndexOf(" ")));
            //display last name in full name
            Console.WriteLine(fullname.Substring(fullname.LastIndexOf(" ")+1));
            int v1 = 100;
            Console.WriteLine($"value is {v1} and datatype is {v1.GetType()}");
            char v2 = 'a';
            Console.WriteLine($"value is {v2} and datatype is {v2.GetType()}");
            double v3 = 5.67;
            Console.WriteLine($"value is {v3} and datatype is {v3.GetType()}");
            bool v4 = true;
            Console.WriteLine($"value is {v4} and datatype is {v4.GetType()}");
            //ask user input
            Console.WriteLine("Whats your name?");
            string username = Console.ReadLine();//TReading data from the user
            Console.WriteLine($"hello{username},How are you?");
            //asking number
            Console.WriteLine("Enter number");
            int n  = Convert.ToInt32(Console.ReadLine());//TReading data from the user
            Console.WriteLine($"Given number is:{n}");
            Console.WriteLine($"next number of {n} is:{n+1}");
            Console.WriteLine($"square of {n} is:{n*n}");
            Console.WriteLine($"Cube of {n} is :{n*n*n}");
            //2 numbers 
            Console.WriteLine("Enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" a={a},b={b}");
            Console.WriteLine($"Addition of {a} and {b} is:{a+b}");
            Console.WriteLine($"Subtraction of {a} and {b} is:{a - b}");
            Console.WriteLine($"Multi {a} and {b} is:{a * b}");
            Console.WriteLine($"Div {a} and {b} is:{b / a}");






        }
    }
}
//F5=DEBUG THE PROJECT
//SHIFT+F5=STOP DEBUG THE PROJECT
//CNTRL+F5=TO RUN THE PROJECT
/*
 MULTILINE COMMENTS
 */
