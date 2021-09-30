using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
                                            


//LINQ




namespace ConsoleApp1
{/*
    class program28
    {
        static void Main(string[] args)
        {
            //  string[] items = new string[] { "flower", "plate", "fruit", "picture", "dish" };
            //int[] items = new int[] { 10,20,30,40,50};
            //List<int> items = new List<int> { 10, 20, 30, 40 };
            List<string> items = new List<string> { "banana", "cherry", "apple", "mango" };
            var query = from item in items select item;
            foreach(var item in query)
                Console.WriteLine(item);

        }
        
   

   
    }
   
    //extension methods
    static class IntegerExtensionMethods
    {
      public static int Square(this int n)
        {
            return n * n;
        }
        public static int next(this int n)
        {
            return n+1;
        }
    }
    class program28
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(n);
            Console.WriteLine(n.next());
            Console.WriteLine(n.next().next());
            Console.WriteLine(n.Square());
            Console.WriteLine(n.next().Square());

        }
    }
     */
    //STRING EXTENSION METHODS
    static class StringExtensionMethods
    {
        public static string Upper(this string name)
        {
            return name.ToUpper();
        }
        public static string FirstName(this string fullname)
        {
            return fullname.Substring(0,fullname.IndexOf(" "));
        }
        public static string lastName(this string fullname)
        {
            return fullname.Substring(fullname.LastIndexOf(" ")+1);
        }

    }
    class program28
    {
        static void Main(string[] args)
        {
            string fullname = "Revanth Vokkaliga";
            Console.WriteLine(fullname.Upper());
            Console.WriteLine(fullname.FirstName());
            Console.WriteLine(fullname.lastName());



        }
    }


}
/*
 * Linq: Language Integrated Query
 * Line enable us to interact with datasource  with a single syntax 
 Data sources like like array, collection, file, database, etc., 
In order to use linq feature we can use following ways
a) Sql like queries
b) Linq like queries
 
extension method:it is a method ehich can be added to existing type to provide topup functionality
*/