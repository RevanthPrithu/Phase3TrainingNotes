using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*class program35
    {
        interface IPrintScanTasks
        {
            void PrintContent(string content);
            void ScanContent(string content);
            void PhotoCopyContent(string content);
        }
        interface IFaxTasks
        {
            void FaxContent(string content);
        }
        interface IDuplexTaskx
        {
            void PrintDuplexContent(string content);
        }
        class HpPrinter : IPrintScanTasks, IFaxTasks
        {
            public void FaxContent(string content)
            {
                Console.WriteLine("Can Send fax to the destination");
            }
            public void PhotoCopyContent(string content)
            {
                Console.WriteLine("Can take xerox copy");
            }
            public void PrintContent(string content)
            {
                Console.WriteLine("Can take a printout");
            }
            public void ScanContent(string content)
            {
                Console.WriteLine("Can scan content to system");
            }
        }
         class CanonPrinter : IPrintScanTasks, IDuplexTaskx
    {
        public void PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintContent(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }
        public void ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
        static void Main(string[] args)
        {

        }
    }

    //OCP EXAMPLE
    
    abstract class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public Employee()
        { }
        public Employee(int Id, string EName)
        {
            this.Id = Id; this.EName = EName;
        }
        public abstract double CalculateBonus(int salary);
        public void GetDetails()
        {
            Console.WriteLine($"{Id} {EName} ");
        }
    }
    class PermnantEmployee : Employee
    {
        public PermnantEmployee()
        {
        }
        public PermnantEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.1;
        }
    }
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
        }
        public TemporaryEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary) //extension and valid
        {
            return salary * 0.05;
        }
    }
    class ContractEmployee : Employee
    {
        public ContractEmployee()
        {
        }
        public ContractEmployee(int Id, string EName) : base(Id, EName)
        { }
        public override double CalculateBonus(int salary)
        {
            return salary * 0.09;
        }
    }
    class program35
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermnantEmployee(1001, "Meghana");
            Employee e2 = new TemporaryEmployee(1002, "Kiran");
            Employee e3 = new ContractEmployee(1003, "Rani");
            e1.CalculateBonus(25000); e2.CalculateBonus(20000); e3.CalculateBonus(15000);
            e1.GetDetails();
            e2.GetDetails();
            e3.GetDetails();
            Console.ReadKey();
        }
    }
    
    //singleton example
    class singleton
    {
        private static singleton instance = null;
        public  static singleton Instantiate()
        {
            if (instance == null)
                instance = new singleton();
            return instance;
        }
        public void GetDetails(string msg)
        {
            Console.WriteLine("hello" + msg);
        }
    }
    class program35
    {
        static void Main(string[] args)
        {
            
            singleton o1 = singleton.Instantiate();
            o1.GetDetails("from training");
            singleton o2 = singleton.Instantiate();
            o2.GetDetails("from development");
        }
    }
    
    //factory pattern
    interface IShape
    {
        void GetShape();
    }
    class Triangle : IShape
    {
        public void GetShape() => Console.WriteLine("I am a triangle and I have 3 sides");
    }
    class Square : IShape
    {
        public void GetShape() => Console.WriteLine("I am a Square and I have 4 equal sides");
    }
    class Rectangle : IShape
    {
        public void GetShape() => Console.WriteLine("I have a rectangle and U have 4 sides but not equal");
    }
    class Factory
    {
        public static IShape Initialize(Shape shape)
        {
            IShape type = null;
            if (shape == Shape.Rectangle)
                type = new Rectangle();
            else if (shape == Shape.Square)
                type = new Square();
            else if (shape == Shape.Triangle)
                type = new Triangle();
            return type;
        }
    }
    enum Shape
    {
        Square, Rectangle, Triangle
    }
    class program35
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice [1: Triangle /2: Rectangle /3: Square]: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Shape shape = Shape.Square;
            if (ch == 1) shape = Shape.Triangle;
            else if (ch == 2) shape = Shape.Rectangle;
            else if (ch == 3) shape = Shape.Square;
            IShape shape1 = Factory.Initialize(shape);
            shape1.GetShape();
        }
    }
   

    //Dependency injection example1

    interface IItem
    {
        string Cook();
    }
    class NonVeg : IItem
    {
        private string dish;
        public NonVeg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Non Veg " + dish + " cooked, ready and start eating";
        }
    }
    class Veg : IItem
    {
        private string dish;
        public Veg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Veg " + dish + " cooked, ready and start eating";
        }
    }

    class ExpertCook
    {
        IItem item;
        public ExpertCook(IItem item)
        {
            this.item = item;
        }
        public void StartEating()
        {
            if (this.item == null)
                Console.WriteLine("Dish not available, sorry");
            else
                Console.WriteLine(item.Cook());
        }
    }
    class program35
    {
        static void Main(string[] args)
        {
            ExpertCook ck1 = new ExpertCook(new NonVeg("Chilli Chicken"));
            ExpertCook ck2 = new ExpertCook(new Veg("French fries"));
            ck1.StartEating();
            ck2.StartEating();
        }
    }
     
    //Dependency injection example2
    interface IDal
    {
        void ConnectToDB();
        void AccessData();
    }
    class SqlDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to MS Sql Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth fromSql server");
        }
    }
    class OraDal : IDal
    {
        public void ConnectToDB()
        {
            Console.WriteLine("Connected to Oracle DB Server");
        }
        public void AccessData()
        {
            Console.WriteLine("Customer data bougth from Oracle DB");
        }
    }
    class Customer
    {
        IDal dal;
        public Customer(IDal dal)
        {
            this.dal = dal;
        }
        public void GetData()
        {
            dal.ConnectToDB();
            dal.AccessData();
        }
    }
    class program35
    {
        static void Main(string[] args)
        {
            Customer o1 = new Customer(new SqlDal());
            o1.GetData();
            Customer o2 = new Customer(new OraDal());
            o2.GetData();
        }



    }
    */

    
}
/*
 Open Closed Principle(OCP)
In the project, software entities such as classes, modules, functions, etc., should be open for extension but closed for modification.
The new features should be implemented by adding classes, attributes and methods, instead of changing the existing one. 
 

//singleton
Singleton pattern,  fall under Creational Pattern categories
This feature used to instantiate object once in the application (Restrict client to create an object) 
There are situations in a project that only one instance of object to be created and shared between different parties.
First time when object is accessed the copy created; later this copy will be used.
Services with business logic are implemented in singleton pattern.
Session object is a singleton
Behave like a Global Object for the Project
Steps to create Singleton:
    Define a private constructor ( so than object cannot be created)
    Define the instance into static 
    Methods can be static or non static

 In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.
 
 
  * DI (Dependency Injection) is a technique whereby one object supplies the dependencies of another object. A dependency is an object that can be used (a service). An injection is the passing of a dependency to a dependent object (a client) that would use it.
In real time the services are injected to a class using DI mechanism

public List<EmpModel> GetAllEmployees() => employees;
        public EmpModel GetEmployeeById(int id)
        {
            return employees.Single(x => x.Id == id);
        }
        public void AddEmployee(EmpModel e)
        {
            employees.Add(e);
        }
        public void EditEmployee( EmpModel e)
        {
            int index = employees.FindIndex(x => x.Id == e.Id);
            employees[index] = e;
        }
        public void DeleteEmployee(EmpModel e)
        {
            int index = employees.FindIndex(x => x.Id == e.Id);
            employees.RemoveAt(index);
        }

 */