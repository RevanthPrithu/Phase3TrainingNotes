using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main(string[] args)
        {
            object o1 = "revu";//boxing
            Console.WriteLine(o1 + " "+o1.GetType());

            string name = o1.ToString();//unboxing
            Console.WriteLine(name + " " + name.GetType());

            o1 = 1000;//boxing
            Console.WriteLine(o1 + " " + o1.GetType());
            int n = (int)o1;//unboxing
            Console.WriteLine(n + " " + n.GetType());



        }
    }
}
/*
 The datatypes used in .NET  are available in a hierachy called CTS (Common Type System)
The root type is Object,all data types like int, char,double etc., derived from Object type
Object type variable allowed to store any type of data called boxing
Boxing refers to assign any type of data into object type
Unboxing refers to dereference the boxed value
 */
