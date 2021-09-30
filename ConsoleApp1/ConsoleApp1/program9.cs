using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum MaritialStatus
    {
        Married,UnMarried,Divorce
    }
    class program9
    {
        static void Main(string[] args)
        {
            MaritialStatus p1 = MaritialStatus.Married;
            if (p1 == MaritialStatus.Married)
                Console.WriteLine("You can leave office at 7pm");
            else if (p1 == MaritialStatus.UnMarried)
                Console.WriteLine("you have to stay till 8pm");
            else Console.WriteLine("You can leave anytime");
        }
    }
}
/*
    enum: enumerated type, used to have set of constants
    Example:    Gender, MartialStatus, Color, Direction
 
  const used to have constatnt variable, which cannot be changed
   const string directorName= "Raj";
    Console.WriteLine(directorName);
 */