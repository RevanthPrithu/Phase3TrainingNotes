using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class program31
    {
        static void Main(string[] args)
        {
            /*Action<string> wishes = x => Console.WriteLine($"Hello {x} ,welcome");
            wishes("revanth");
            wishes("reva");
            
            Func<int, int> square = x => x * x;
            Func<int, int> next = x => x * x;
            Func<int, int> cube = x => x * x;
            Func<int, int,int> Add = (a,b)=>a+b;
            Func<int, int,int> Sub = (a, b) => a - b;
            Func<int, int, int> Big = (a, b) => a > b ? a : b ;
            Func<int, int,int> Small = (a, b) => a < b ? a : b;

            Console.WriteLine(square(5));
            Console.WriteLine(next(5));
            Console.WriteLine(Add(30,3));
            Console.WriteLine(Sub(30, 3));
            Console.WriteLine(Big(30, 3));
            Console.WriteLine(Small(30, 3));


            Func<string, string> upper = x => x.ToUpper();
            Func<string, int> len = x => x.Length;
            Func<string, string> fname = x => x.Substring(0,x.IndexOf(" "));
            Func<string, string> lname = x => x.Substring( x.LastIndexOf(" ")+1);

            Console.WriteLine(len("Revanth M"));
            Console.WriteLine(upper("Revanth M"));
            Console.WriteLine(fname("Revanth M"));
            Console.WriteLine(lname("Revanth M"));
            
            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Sub = (a, b) => a - b;
            Func<int, int, int> Big = (a, b) => a > b ? a : b;
            Func<Func<int, int, int>, int, int, int> Calculate = (cb, a, b) =>  cb(a, b);

            Console.WriteLine(Calculate(Add,10,20));
            Console.WriteLine(Calculate(Big, 10, 20));

            Console.WriteLine(Calculate((a,b)=> a-b,10,20));
            Console.WriteLine(Calculate((a, b) => a < b ? a : b, 10, 20));
            */
            List<string> items = new List<string> { "banana", "cherryyyyyyyy", "apple", "mango" };

             //var query = from item in items select item;
            //var query = from item in items orderby item select item;
           // var query = from item in items orderby item descending select item;
            //var query = from item in items orderby item.Length select item;
            // var query = from item in items orderby item.Length descending select item;
           //  var query = from item in items orderby item.Length==5 select item;
           // var query = items.Where(x => x.Length == 5);
            //foreach(string item in query)
                // Console.WriteLine(item);


        }
    }
}
/* lamda expression:It is a simple and a short function definition which can be provided definition as an argument
 * Adv: Instant implementation
 * will  use inbuilt delegates(Action,Func,Predicate) for demo purpose
 * this lamda expression is called as arrow functioons in JS
 * */
