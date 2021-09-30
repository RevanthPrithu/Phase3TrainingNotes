using System;

namespace PracticeQuestions
{
    class Program
    {
        void uppercaseAlphabets()
        {
            for (int c = 65; c <= 90; ++c)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }
      
        void uppercaseAlphabetsRev()
            {
                for (int c = 90; c >= 65; c--)
                    Console.Write(" " + (char)c);
                Console.Write("\n");
            }
            void lowercaseAlphabets()
            {
                for (int c = 97; c <= 122; ++c)
                    Console.Write(" " + (char)c);
                Console.Write("\n");
            }
        void lowercaseAlphabetsRev()
        {
            for (int c = 122; c >= 97; c--)
                Console.Write(" " + (char)c);
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            //program 01 to check whether number is palindrome or not

            //int num, rem, sum = 0, temp;  
            //Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            //Console.Write("\n Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //temp = num;
            //while (num > 0)
            //{
            //    rem = num % 10; //for getting remainder by dividing with 10    
            //    num = num / 10; //for getting quotient by dividing with 10    
            //    sum = sum * 10 + rem;
            //}
            //Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            //if (temp == sum)    
            //{
            //    Console.WriteLine("\n Number is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("\n Number is not a palindrome");
            //}
            //Console.ReadLine();


            //Program 02 - whether the number is prime or not


            //int num, i, ctr = 0;
            //Console.Write("Check whether a given number is prime or not:\n");

            //Console.Write("\n");

            //Console.Write("Input  a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (i = 2; i <= num / 2; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        ctr++;
            //        break;
            //    }
            //}
            //if (ctr == 0 && num != 1)
            //    Console.Write("{0} is a prime number.\n", num);
            //else
            //    Console.Write("{0} is not a prime number\n", num);


            //Program 03-check the given number is Armstrong or not

            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number= ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = sum + (r * r * r);
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.Write("Armstrong Number.");
            //else
            //    Console.Write("Not Armstrong Number.");


            //program -04-read a number and check the given number is perfect or not

            //int n, i, sum;
            //Console.Write("Check whether a given number is perfect number or not:\n");
            //Console.Write("\n");
            //Console.Write("Input the  number : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //sum = 0;
            //Console.Write("The positive divisor is : ");
            //for (i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        sum = sum + i;
            //        Console.Write("{0}  ", i);
            //    }
            //}
            //Console.Write("\nThe sum of the divisor is : {0}", sum);
            //if (sum == n)
            //    Console.Write("\n Hence, the number is perfect.");
            //else
            //    Console.Write("\n Hence, the number is not perfect.");
            //Console.Write("\n");


            //Program4-Display sum of 1 to n number excluding numbers divisible by 5 and 7
            //Say from 1to 100


            //int a = 0;
            //Console.WriteLine("Divided by 5 and 7: ");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 || i % 7 == 0)
            //    {
            //        //Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        a = a + i;
            //    }

            //}
            //Console.WriteLine(  $" Sum of Numbers that are not divisible by 5 and 7 in between 1 to 100 is :{a}");

            //Program5 - Program to display capital letter alphabets (A-Z) (ASCII 65-90)

            
            Console.WriteLine("Uppercase Alphabets are as follows");
            //Program o = new Program();
            //o.uppercaseAlphabets();
            // // program -6 to dispaly lower case alphabets
            //Console.WriteLine("Lowercase Alphabets are as follows  ");
            //o.lowercaseAlphabets();

            ////program-7 display capital letters from Z-A
            //Console.WriteLine("UpperCase letters in Reverse Order");
            //Program ob = new Program();
            //ob.uppercaseAlphabetsRev();

            ////program-8 display capital letters from z-a
            //Console.WriteLine("LowerCase letters in Reverse Order");
            //Program ol = new Program();
            //ol.lowercaseAlphabetsRev();


            //program-9 display odd numbers from 2 to 9

            //Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            //for (int n = 2; n < (9 + 1); n++)
            //{
            //    if (n % 2 != 0)
            //    {
            //        Console.WriteLine(n.ToString());
            //    }
            //}


            //Program 10-display numbers divisible by 2 and 20 both 
            //Console.WriteLine("Divided by 2 & 20: ");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0 && i % 20 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            //program11-display even numbers from 15-25
            //int i = 0;

            //Console.WriteLine("Even Numbers :");
            //for (i = 15; i <= 25; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //program12- Program to generate factors of a given number

            //int num, x;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}
            //Console.ReadLine();


            //program13-  Program to display even factors of given number
            //int num, x;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0 && x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}


            //program14-Program to display odd factors of a given number
            //int num, x;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0 && x % 2 != 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}


            //program15=Program to display count of factors

            //int num, x;
            //int a = 0;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0)
            //    {
            //        a = a + 1;

            //    }
            //}
            //Console.WriteLine($"No. of factors are :{a}");


            //program 16-Program to display number of even factors 
            //int num, x;
            //int a = 0;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0 && x % 2 == 0)
            //    {
            //        a = a + 1;
            //        Console.WriteLine(x);
            //    }
            //}
            //Console.WriteLine($"No. of even factors are :{a}");

            //program-17 to find number of odd factors

            //int num, x;
            //int a = 0;
            //Console.WriteLine("Enter the Number ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Factors are : ");
            //for (x = 1; x <= num; x++)
            //{
            //    if (num % x == 0 && x % 2 != 0)
            //    {
            //        a = a + 1;
            //        Console.WriteLine(x);
            //    }
            //}
            //Console.WriteLine($"No. of odd factors are :{a}");


        }
    }
}
