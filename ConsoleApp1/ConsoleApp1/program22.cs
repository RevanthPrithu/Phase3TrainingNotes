using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Today
    {
        public static bool IsSunday()
        {
            return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() == "sun";
        }
        public static bool IsFriday()
        {
            return DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower() == "fri";
        }
        public static bool IsOfficeHours()
        {
            int hour = DateTime.Now.Hour;
            return (hour >= 9 && hour <= 17);
        }
    }
    class BankAccount
    {
        private int accountBalance;
        private string cname;
        public BankAccount(string cname = "Not Provided", int amount = 0)
        {
            this.cname = cname;
            if (Today.IsFriday())
            {
                this.accountBalance = 500;
                Console.WriteLine($"Congratulations {this.cname} account opened sucessfully, you got 500rs welcome bonus");
            }
            else
            {
                this.accountBalance = 0;
                Console.WriteLine($"Congrtulations {this.cname}, account opened successfully...");
            }
            this.accountBalance += amount;
            Console.WriteLine("=========================================================");
            Thread.Sleep(3000);
        }
        public void Deposit(int amount)
        {
            Console.WriteLine($"Attempt by {this.cname}: Deposit request for {amount} at {DateTime.Now}");

            if (Today.IsSunday())
            {
                Console.WriteLine($"Status: Deposit request failed as You cannot deposit on sunday");
            }
            else if (!Today.IsOfficeHours())
            {
                Console.WriteLine($"Status: Deposit request failed as You cannot deposit out of office hours");
            }
            else if (amount > 50000)
            {
                Console.WriteLine($"Status: Deposit failed, You cannot deposit  50k above, pls check with manager");
            }
            else
            {
                this.accountBalance += amount;
                Console.WriteLine($"Status: Deposited {amount} successfully...");
            }
            Console.WriteLine("=======================================================");
            Thread.Sleep(3000);
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {this.cname}, Account balance: {this.accountBalance}");
        }
    }
    class program22
    {
        static void Main(string[] args)
        {
            BankAccount c1 = new BankAccount("Kiran", 5000);
            BankAccount c2 = new BankAccount();
            c1.Deposit(55000);
            c2.Deposit(12500);


        }
    }
}
