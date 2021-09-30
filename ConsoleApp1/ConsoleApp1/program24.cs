using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  /*  class EmpBaseClass
    {
        protected int id, holiday;
        protected string ename, empType;
        public EmpBaseClass(int id, string ename)
        {
            this.id = id; this.ename = ename;
        }
        public virtual  void GetDetails()
        {
            Console.WriteLine($"id={id},name={ename},emptype={empType},holiday={holiday}");
            
        
        } 

    }
    class PartTimeEmployee : EmpBaseClass
    {
        public PartTimeEmployee(int id, string ename) : base(id,ename)
        {
            this.id =id;this.ename = ename;this.empType = "Parttime";
            this.holiday = 1;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"id={id},name={ename},emptype={empType},holiday={holiday}");
        }
    }
    class FullTimeEmployee : EmpBaseClass
    {
        public FullTimeEmployee(int id, string ename) : base(id, ename)
        {
            this.id = id; this.ename = ename; this.empType = "Fulltime";
            this.holiday = 5;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"id={id},name={ename},emptype={empType},holiday={holiday}");
        }
    }

    class program24
    {
        static void Main(string[] args)
        {
            PartTimeEmployee e1 = new PartTimeEmployee(101, "rev");
            FullTimeEmployee e2 = new FullTimeEmployee(102, "riv");
            e1.GetDetails();
            e2.GetDetails();

        }
    }
  */
  //ABSTRACT CLASS

   /* abstract class OpenUniversity
    {
        public void Course()
        {
            Console.WriteLine("Courses are are designed by univ");
        }
        public void Exams()
        {
            Console.WriteLine("Exams Conducted by university");
        }
        public abstract void Enrollments();
        public abstract void Training();
    }
    class StudyCenter:OpenUniversity
    {
        public override void Enrollments()
        {
            Console.WriteLine("Advertisement and enrollments at study center");
        }
        public override void Training()
        {
            Console.WriteLine("Trainings at study center");
        }
    }
    class program24
    {
        static void Main(string[] args)
        {
            OpenUniversity o1 = new StudyCenter();
            o1.Course();
            o1.Enrollments();
            o1.Training();
        }
    }
   */
   /*
   interface Imail
   {
        void Compose();
        void Inbox();

   }
    class gmail : Imail
    {
        public void Compose()
        {
            Console.WriteLine("Code to send email");
            Console.WriteLine("Helps to write emails");
        }
        public void Inbox()
        {
            Console.WriteLine("Code to send email");
            Console.WriteLine("Helps to read received email");
        }
    }
    class program24
    {
        static void Main(string[] args)
        {
            Imail email;
            email = new gmail();
            email.Compose();
            email.Inbox();
        }
    }
*/
   partial class MyClass
    {
        public void Display1()
        {
            Console.WriteLine("Hello from Display1");


        }
        public void Display2()
        {
            Console.WriteLine("Hello from Display2");


        }

    }
    class program24
    {
        static void Main(string[] args)
        {
            MyClass o1 = new MyClass();
            o1.Display1();
            o1.Display2();
        }
    }

}
/*An abstract class is a partially implemented class.
An abstract class is a class contains both abstract (unimplemented) methods and concrete(implemented) methods, Abstract classes cannot be instantiated.
Why do we need?
It is used in the scenarios like part of the implementation to be done in derived (child) class.
Points to note:
    Abstract class contains abstract methods and concrete methods.
    An abstract class may or may not contain abstract method.
    An abstract class may or may not contain concrete method.
    Any class want to treat must inherit should be abstract (Abstract class must inherit)
    Abstract method should be in public modifier.
What is an abstract method?
This is an unimplemented method, Abstract methods must override in child class.
What are concrete methods?
Concreted methods are the methods which are implemented (also called as non abstract methods).
These are the implemented methods in abstract class.
Real time example:
Array is an abract class




Interface is one of the type like class in oops programming.
Why do we need interface?
Interface is used as a contract, it contains only method specification (without implementation).
The methods in interface must implement in the derived classes
Points to note:    
    In C#.NET interface name should prefix with I (standard)
    The default access modifier in interface is public
    All the methods in interface are abstract
    Interface should not contains fields
C#.NET Collection API root type is IEnumerable is an Interface
IEnumerator if the return type of GetEnumerator in IEnumerable interface, which implement foreach loop
/*
 Interface is one of the type like class in oops programming.
Why do we need interface?
Interface is used as a contract, it contains only method specification (without implementation).
The methods in interface must implement in the derived classes
Points to note:    
    In C#.NET interface name should prefix with I (standard)
  
  






*/


