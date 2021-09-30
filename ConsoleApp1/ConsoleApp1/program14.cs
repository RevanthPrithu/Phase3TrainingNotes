using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program14
    {
        static void Main(string[] args)
        {
            int[] items; //Array declaration
            items = new int[5];//memory allocation
            items[0] = 1000;
            items[1] = 2000;
            items[2] = 3000;
            items[3] = 4000;
            items[4] = 5000;
            Console.WriteLine($"{items[0]}");
            Console.WriteLine($"{items[1]}");
            Console.WriteLine($"{items[2]}");
            Console.WriteLine($"{items[3]}");
            Console.WriteLine($"{items[4]}");

            int[] products = new int[5] {0,1,2,3,4 };//Array initialisation
            for (int i = 0; i < products.Length; i++)
                Console.Write($"{products[i]}");
            //reading input values
            //int[] arrayinput = new int[10];
            //Console.WriteLine("Enter input values;");
            //for (int j=0;j<arrayinput.Length;j++)
            //{
                //Console.Write($"Enter values for array[{j}]");
                //arrayinput[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int k = 0; k < arrayinput.Length; k++)
              //  Console.WriteLine($"items[{k}]={arrayinput[k]}");
            //for string names
            string[] names = new string[5] { "rev", "sac", "kesh", "poor", "ranj" };//Array initialisation
            for (int i = 0; i < names.Length; i++)
                Console.Write($"{names[i]}   ");
            // finding sum avg and count in array
            
            /*int[] arrayinput = new int[10];
            int sum = 0;
            int count = arrayinput.Length;
            double avg = 0;
            Console.WriteLine("Enter input values;");
            for (int j=0;j<arrayinput.Length;j++)
            {
            Console.Write($"Enter values for array[{j}]");
            arrayinput[j] = Convert.ToInt32(Console.ReadLine());
                sum += arrayinput[j];
            
            }
            avg = (double)sum / count;

            for (int k = 0; k < arrayinput.Length; k++)
              Console.WriteLine($"items[{k}]={arrayinput[k]}");
            Console.WriteLine($"Count of elements{count}");
            Console.WriteLine($"Sum of elements{sum}");
            Console.WriteLine($"Avg of elements{avg}");
            */


            // finding big and small elements in array;
            int[] arrayinput = new int[10];
            int sum = 0;
            int count = arrayinput.Length;
            double avg = 0;
            int big = 0;
            int small = 0;

            Console.WriteLine("Enter input values;");
            for (int j = 0; j < arrayinput.Length; j++)
            {
                Console.Write($"Enter values for array[{j}]");
                arrayinput[j] = Convert.ToInt32(Console.ReadLine());
                sum += arrayinput[j];
                if (j == 0)
                    big = small = arrayinput[0];
                else if (arrayinput[j] > big)
                    big = arrayinput[j];
                else if 
                    (arrayinput[j]<small)
                        small = arrayinput[j];

            }
            avg = (double)sum / count;

            for (int k = 0; k < arrayinput.Length; k++)
                Console.WriteLine($"items[{k}]={arrayinput[k]}");
            Console.WriteLine($"Count of elements{count}");
            Console.WriteLine($"Sum of elements{sum}");
            Console.WriteLine($"Avg of elements{avg}");
            Console.WriteLine($"BIGGEST of elements{big}");
            Console.WriteLine($"SMALLEST of elements{small}");



        }
    }
}
/*
 * Array is a Programming feature, allow to store more than one value within a single identification and programmable. All elements will store in homogeneous order. Arrays are the best place to handle limited number of elements.
Application of an Array:
    Days in a month, Hours in day,     Students in a classroom,  Seats in  bus, etc.,
Points to note:
Array is Abstract class in .NET Collection API
Array declared at compiled time (Stored in Stack Memory)
Arrays are index based collection, accessible using [ ] notation.
First element is accessible using 0 index, last element is accessible using Length-1 as index
Dimensions are accessible using Rank property
Limitations:
               Array variable will store one type of data.    
    Array variable size fixed (cannot enhance).
    Insertion, deletion and sorting, searching of elements in array is big process.
 */

