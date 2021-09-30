using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //with single Responsible Principle(Decoupling)
    interface IUser
    {
        void SignUp();  //User Registration
        void SignIn();  //User Login
    }
    interface IEmail
    {
        void Compose();     //To send an email
        void ChekEmails();  //To receive an email
    }
    interface ILogger
    {
        void LogErrors();   //To log error
    }
    class Email : IUser, IEmail, ILogger
    {
        public void ChekEmails()
        {
            Console.WriteLine("Check Email: Code for Email Inbox");
        }
        public void Compose()
        {
            Console.WriteLine("Compose: Code to send an email");
        }
        public void LogErrors()
        {
            Console.WriteLine("Log errors: Code to log the erros");
        }
        public void SignIn()
        {
            Console.WriteLine("Sign In: Code to login to a user account");
        }
        public void SignUp()
        {
            Console.WriteLine("Sign Up: Code to register user");
        }
    }



    class program34
    {
        static void Main(string[] args)
        {
            Email o = new Email();
            o.SignUp();
            o.SignIn();
            o.ChekEmails();
            o.Compose();
            o.LogErrors();
        }
    }
}
/*
 Design patterns are the solutions for Software Designs, 
    these are reusable solutions to the problems that we encounter in the day to day programming. 
They are generally targeted at solving the problems of object generation and integration. 
In other words, Design patterns acts as templates which can be applied to the real-world programming problems.
 
 SOLID Principals
Single Responsibility Principle (SRP)
A class should take one responsibility and there should be one reason to change that class.
Every class or a module should have responsibility over a single part of the functionality provided by the software that responsibility should entirely encapsulate by that class.
Motivations:
    Maintainability
    Testability
    Flexibility and extensibility
    Parallel Development
    Loosely Coupling
    SOLID principals and Design Pattern play key role in the above motivations
Open Closed Principle(OCP)
In the project, software entities such as classes, modules, functions, etc., should be open for extension but closed for modification.
The new features should be implemented by adding classes, attributes and methods, instead of changing the existing one. 

 Liskov Substitution Principle(LSP)
This principle is simple but very important to understand. Child class should not break parent class’s type definition and behaviour.
No new exceptions to be thrown by sub type
Example: Hierarchical inheritance with Employee as base and PartTime and FullTime as child classes
Interface Segregation Principle(ISP)
No Client should be forced to dependent methods if does not use it
This principle states that any client should not be forced to use an interface which is irrelevant to it.
Dependency Inversion Principle(DIP)
This principle tells you not to write any tightly coupled code because that is a nightmare to maintain when the application is growing bigger and bigger.
High level modules should not depend on low level modules, both should depend on abstractions.

/*
 Open Closed Principle(OCP)
In the project, software entities such as classes, modules, functions, etc., should be open for extension but closed for modification.
The new features should be implemented by adding classes, attributes and methods, instead of changing the existing one. 
 */










