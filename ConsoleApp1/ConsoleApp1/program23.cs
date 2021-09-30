using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* class BaseClass
     {
         private int dm1 = 100;//this is acessible within class only
         protected int dm2 = 200;//this is accessible within derived classes
         public int dm3 = 300;//this is accessible everywhere
         public void DisplayBase()
         {
             Console.WriteLine($"dm2={dm2},dm3={dm3}");
         }
     }
     class DerivedClass : BaseClass
     {
         public void DisplayDerived()
         {
             //dm1 is inaccessible due to its protection level
             Console.WriteLine($"dm2={dm2},dm3={dm3}");
         }
     }
     class program23
     {
         static void Main(string[] args)
         {
             DerivedClass o1 = new DerivedClass();
             o1.DisplayBase();
             o1.DisplayDerived();
             Console.WriteLine(o1.dm3);

         }
     }
    */
    class ParentClass
    {
        protected string name;
        protected int age;
        public ParentClass(string name,int age)
        {
            //Console.WriteLine("Parent class constructor");
            this.name = name;this.age = age;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Parent name:{name},Age{age}");
          //  Console.WriteLine("Hello from base /parent  display");
        }

    }
    /*class Intermediate : ParentClass
    {
        public Intermediate()
        {
            Console.WriteLine("Intermediate class constructor");
        }
    }
    */
   // class ChildClass : Intermediate
    class ChildClass : ParentClass
    {
        // public ChildClass():base() //Constructor overriding
        public ChildClass(string name,int age):base(name,age)
        {
           // Console.WriteLine("Child class constructor");
        }
        public override void Display()
        {
            //base.Display();//invoke base class method from child class
            // Console.WriteLine("Hello from derived/child display");
            Console.WriteLine($"childname:{name},age={age}");
        }
    }
     class program23
    {
        static void Main(string[] args)
        {
            // ChildClass o1 = new ChildClass();
            ParentClass o1;
            //o1 = new ParentClass();
            o1 = new ParentClass("rev",22);
            o1.Display();
            o1 = new ChildClass("riv",2);
            o1.Display();
        }
    }
}
/*
 * Virtual method
 * 
 * When the object declared for base class and memory allocated to derived , 
 * the base class method override even memory refers to child class
 * 
 * to overcome prefix virtual to the base class method and override in child cla

*/
