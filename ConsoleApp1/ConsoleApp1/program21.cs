using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /* class Number
     {
         //data functions section
         private int num1;//can use two nums and also pass parameters
         public void SetNumber(int num1)
         {
             this.num1 = num1;
         }
         public void GetNumber()
         {
             Console.WriteLine($"num1={this.num1}");
         }
     }
     class program21
     {
         static void Main(string[] args)
         {
             Number n1 = new Number();
             n1.SetNumber(100);
             n1.GetNumber();
         }
     }
    */
    /* Define Person class with pname, gender and age as data members
    Implement SetDetails() and GetDetails method
    Declare 2 object access
   
    class Person
    {
        private string pname, gender;
        private int age;
        public void SetDetails(string pname, string gender, int age)
        {
            this.pname = pname;
            this.gender = gender;
            this.age = age;

        }
        public void Getdetails()
        {
            Console.WriteLine($"{this.pname}{this.gender}{this.age}");
        }
    }
    class program21
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.SetDetails("Rev", "Male", 22);
            p2.SetDetails("nir", "Male", 22);
            p1.Getdetails();
            p2.Getdetails();
        }

    }
     */

    //CONSTRUCTORS
    /*
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Object instantiatiom");
        }
    }
    class program21
    {
        static void Main(string[] args)
        {
            ConstructorDemo o1 = new ConstructorDemo();
            ConstructorDemo o2 = new ConstructorDemo();
        }
    }
   

    class Student
    {
        private int id, fee;
        private string sname, course;
        public Student(int id = -1, string sname = "Not provided", string course = ".Net", int fee = 1000)
        {
            this.id = id;
            this.sname = sname;
            this.course = course;
            this.fee = fee;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{this.id} {this.sname}{this.course}{this.course}{this.fee}");

        }
    }
    class program21
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1001, "Rev", "MVC.net", 5000);
            Student s3 = new Student();
            s1.GetDetails();
            s3.GetDetails();
        }
    }
   */
    enum VehicleType
    {
        TwoWheeler,FourWheeler
    }

    class Parking
    {
        private VehicleType type;
        private int capacity, count, amount, price;
        public Parking(VehicleType type, int count)
        {
            this.type = type; this.count = count;
            if (type == VehicleType.TwoWheeler) { capacity = count > 150 ? 150 : count;
                this.count = count > 150 ? 150 : count; 
                price = 20; }
            else if (type == VehicleType.FourWheeler) { capacity = 40; price = 40; }
             this.amount = this.count * this.price;
        }
        public void AddCount(int count)
        {
            int availableCount = this.capacity - this.count;
            if (count > availableCount)
            {
                Console.WriteLine($"You cannot add more than{availableCount}");
            }
            else
            {
                this.count += count;
                Console.WriteLine($"{count} Vehicles added Succesfully");
            }
            
        }
        
           
       
        public void GetType()
        {
            Console.WriteLine($"Type is:{this.type.ToString()},Capacity:{this.capacity}.price:{this.price},amount={this.amount}");
        }
    }
    class program21
    {
        static void Main(string[] args)
        {
            Parking tw = new Parking(VehicleType.TwoWheeler,50);
            Parking fw = new Parking(VehicleType.FourWheeler,12);

            tw.GetType();
            fw.GetType();
            tw.AddCount(2);
            fw.AddCount(20);
        }
    }














}
/*
Class:    It is a user defined data type
Object:    Instance of a class
Date member:    Refers to variable inside a class
Member function:    Refers to function inside a class
private:    Access modifier restrict access of member to outside
public:        Acess modifier allow access of member to outside
 */
/*
 constructor:    This method is used to instantiate data members
This is a special method
a) Exist with same name of the class
b) Invoke implcitly
Scenario:   The initial formalities while joining in company will be done using construct
*/
/*
 Paramameterized constructor: Used to pass arguments while object creation
Note:   Constructor method can be overloaded
        Constructor method can have default parameter
    
*/

