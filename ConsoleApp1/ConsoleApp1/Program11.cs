using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program11
    {
        static void Main(string[] args)
        {
            //Display wishes based on time
            int hour = DateTime.Now.Hour;
            if (hour < 12) Console.WriteLine("Good Morning");
            else if (hour < 16) Console.WriteLine("Good Afternoon");
            else Console.WriteLine("GoodEvening");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
            if (day == "sat" || day == "sun")
                Console.WriteLine("today is weekend with family");
            else
                Console.WriteLine("Today is weekday and enjoy in the office");
          
        }
    }
}
