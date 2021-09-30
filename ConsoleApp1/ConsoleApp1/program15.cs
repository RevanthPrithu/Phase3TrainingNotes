using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program15
    {
        static void Main(string[] args)
        {
            //2D array
            int[,] items;
            items = new int[2, 2];
            items[0, 0] = 100;
            items[0, 1] = 200;
            items[1, 0] = 300;
            items[1, 1] = 400;
            Console.Write($"{items[0,0]}");
            Console.WriteLine($"{items[0, 1]}");
            Console.Write($"{items[1, 0]}");
            Console.WriteLine($"{items[1,1]}");
            //using for loop
           int [,] prod =  new int[,] {   { 100,    200,    300,   400},   {   500,   600,   700 ,   800}   };
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{prod[i    ,     j]}");
                Console.WriteLine();
            }
            //jagged array declaration
            int[][] jaggedarray;
            jaggedarray = new int[4][];
            jaggedarray[0] = new int[] { 10,     20,    30,    40,    50,   60,   70,    80};
            jaggedarray[1] = new int[] { 1 ,2 };
            jaggedarray[2] = new int[] { 10,    20,    30,     40,    5,    60,   70,   80,  90 };
            jaggedarray[3] = new int[] { 10,   20,   30,    40,    50 };
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)
                    Console.Write($"{jaggedarray    [i]       [j]   }");
                Console.WriteLine();
            }





        }
    }
}
/*
 * Jagged Array is used to declare an Array of Array
Jagged Array can contain different number of columns in every row.
Days in a year:
int[][] months;
months = new int[4][];
months[0] = new int[31];
months[1] = new int[29];
months[2] = new int[31];
months[3] = new int[30];
Scenario:     Students in multiple class rooms
Points to note:
    This feature is available on .NET only (No other programming languages support this feature).
    This is array will have different number of columns in each rows
*/
