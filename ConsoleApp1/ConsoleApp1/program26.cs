using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program26
    {
        /*
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();//by default its a4,8,16 like ,here its empty but we can specify like 45.89.like that
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);

            items.Add("scale");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);
            items.Add("pen");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);
            items.Add("eraser");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);
            items.Add("sharpner");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);
            items.Add("penpencil");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);
        }
       
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();//by default its a4,8,16 like ,here its empty but we can specify like 45.89.like that
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);

            items.Add("eraser");
            items.Add("scale");
            items.Add("paper");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);

            items.TrimToSize();
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);

            items.Add("gum");
            Console.WriteLine($"capacity is:{items.Capacity},count is:{items.Count}");
            Thread.Sleep(500);


        }
         
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add("pen");
            items.Add("100");
            items.Add("a");
            items.Add("true");
            items.Add("45.56");
            //foreach (var item in items) {
              //  Console.WriteLine($"items is {item},datatype is {item.GetType()}");
            //}
            items.Sort();
            items.Reverse();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"items are {i}");
            }
       
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();
            employees.Add("emp1", "rev");
            employees.Add("pgmr", "riv");
            employees.Add("hr1", "rav");
            if (employees.Contains("hr1"))
            {
                Console.WriteLine(employees["hr1"].ToString());

            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();
            employees.Add("emp1", "rev");
            employees.Add("emp2", "revrr");
            employees.Add("pgmr1", "riv");
            employees.Add("pgmr2", "riva");
            employees.Add("hr1", "rav");
            employees.Add("hr2", "reva");

            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            if (employees.Contains(key))
            {
                Console.WriteLine(employees[key].ToString());
            }else
                Console.WriteLine($"{key} not exist");
            Console.WriteLine();
        }
         */
        /* static void Main(string[] args)
         {
             Hashtable employees = new Hashtable();
             employees.Add("emp1", "rev");
             employees.Add("emp2", "revrr");
             employees.Add("pgmr1", "riv");
             employees.Add("pgmr2", "riva");
             employees.Add("hr1", "rav");
             employees.Add("hr2", "reva");
             foreach(DictionaryEntry e in employees)
                 Console.WriteLine($"key ={e.Key} , value ={e.Value}");
         }
        */
        //SORTED LISTS


        static void Main(string[] args)
        {
            SortedList employees = new SortedList();
            employees.Add("emp1", "rev");
            employees.Add("emp2", "revrr");
            employees.Add("pgmr1", "riv");
            employees.Add("pgmr2", "riva");
            employees.Add("hr1", "rav");
            employees.Add("hr2", "reva");
            foreach (DictionaryEntry e in employees)
                Console.WriteLine($"key ={e.Key} , value ={e.Value}");
        }
    }
}

/*
 * Collection:    A collection is an API, contains inbuilt types of data structures
Each collection type has predefined methods and implementation
Advantages:
    Allow to store any type of data
    Any number of elements
    Define methods to perform operations like insert, delete, update, etc.,
Why collection?
    To overcome limtations of an array
    Array:    It is an abstract data type
    Used to group of similar elements within single identification
Limitations in Array:
    a) Array elements allow only one type of data
    b) Array size is fixed (cannot enhance)
    c) Array contains Length attribute only ( a separate count variable to be maintained)
    d) Operations like insert, delete, etc.,will be done by shifting elements
To overcome the limitation we use data structures
Data structures:
    Are based on dynamic memory allocations
OOPs languages provide inbuilt data structures in the form  Collection
Available collection types:
    ArrayList
    LinkedList
    Hashtable
    SorteList
    etc.,
How a collection object items allow different types of data?
    Collection object type take object as parameter
    Object all any type of data using boxing feature
How a collection object allow unlimited items?
The default Capacity is zero
While adding first element the Capacity incrases to 4
While adding fifth element the Capacity incrases to 8
While adding ninth element the Capacity incrases to 16
 To perform operations on collection object the following methods are used
    Add()
    Insert(),
    Remove(),
    RemoveAt(),
    TrimToSize(),
    Sort(),
    Reverse()



hastable :its a key and value paired collection
 
 */
