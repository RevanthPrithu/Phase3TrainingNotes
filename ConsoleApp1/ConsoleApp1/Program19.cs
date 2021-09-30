using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program19
    {
        /*static void Main(string[] args)
        {
            int? a = null;
            if (a is null)
                Console.WriteLine("No value into the variable");
            else
                Console.WriteLine($"Value is {a}");

            string name = string.Empty;
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("name is empty");
            else
                Console.WriteLine($"{name} is the value");
        }
       
        //TRY CATCH PROGRAM
        static void Main(string[] args)
        {
            Console.Write("enter integer");
            int? n = null;
            try
            {
                //this block is used to place statements which may provide exception
                n = Convert.ToInt32(Console.ReadLine());

            }
            catch(FormatException ex)
            {
                //This block is used to handle exception
                Console.WriteLine("Input type not valid" + ex.Message);
                n = 0;
            }
            catch (Exception ex)
            {
                //This block is used to handle exception
                Console.WriteLine("Error:"+ex.Message);
                n = 0;
            }
            finally
            {
                //This block process statement even error is raised or not
                Console.WriteLine($"Square of{n} is {n * n}");
            }
        }
        

        //read 2 numbers ,perform div with handle overflow ,divide by zero exceptions
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int? num1 = null;
            int? num2 = null;
            int? answer = null;
        top:
            try
            {
                Console.Write("Enter value for num1: ");

               num1= Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter value for num2: ");
                num2 =Convert.ToInt32(Console.ReadLine());
                answer = num1 / num2;
      

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("error " + ex.Message);
                answer = num1 / 1;
                goto top;//ask user to re-enter the values;

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                answer = num1 / 1;
                goto top;

            }
            finally
            {
                Console.WriteLine($"Division is :{answer}");
            }
        


    }
        */
        /*
        //Array index exception
        static void Main(string[] args)
        {
            int[] items = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(items[5]);//try to display 6th element

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }
            Console.ReadKey();
        }
        */
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter numbers");
                int[] a = new int[5];
                for (int i = 0; i < 6; i++)
                    a[i] = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine(a[i]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }
        }
    }
}
/*
    An exception is a runtime error; 
    A statement which cannot be understandable or which cannot be handled by the program execution will be treated 
    as runtime error or an Exception.
Like: number divide by zero
    variable content value out of range
    data type mismatch
    array index out of range,etc.,
 */
/*
 * nullbale types: used to have empty value into a variable
 * by prefix ? to the variable
 * int ?n=null;
 * 
 * To compare
 * if( n is null)
 *  statement
 
Exception Handling
    Exception Handling is a mechanism in OOPs feature, to handle runtime errors.
Using Exception Handling we can divert the statement execution instead of termination.
    Keyword    Example/definition
    try     try keyword is used to create block to place the statements which may provide errors (suspicious statements). 
try
{
    c = a / b;
}    try
{
    OpenFile a.txt;
}    try
{
    int n = Covnert.ToInt32(Console.ReadLine());
}
The statements inside try block will not terminate, redirect to catch block.
    catch      This keyword is used to catch the exception and to handle it. Catch helps to continue the program without terminate. The statements under the catch block get executed when the exception is raised.
    throw     throw keyword is used to throw a specified exception (This is optional block).
    finally     Used to execute the final statements in the exception handling
Ex:  File close, Disconnect DB(This is optional block)
*/