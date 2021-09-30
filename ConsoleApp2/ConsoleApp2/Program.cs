using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        public class Teacher
        {
            public int TId { get; set; }
            public string TName { get; set; }
            public int Tclass { get; set; }
            public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            string fpath = @"D:\myfile.txt";
            List<Teacher> teachers = new List<Teacher>();

            Console.WriteLine("What Operation do you need to perform on the Teacher database?:Choose(1/2/3/4)");
            Console.WriteLine("1.Get The Record \n2.Add the Teacher Detail \n3. Delete Teacher Detail \n4.Update the Teacher Record");
            int Key = System.Convert.ToInt32(Console.ReadLine());
            switch (Key)
            {
                case 1://GET THE TEACHER RECORD ON CONSOLE WINDOW
                    //List<string> lines = File.ReadAllLines(fpath).ToList();
                    //foreach(string line in lines)
                    //{
                    //    Console.WriteLine(line);
                    //}
                   
                    List<string> lines = File.ReadAllLines(fpath).ToList();
                    foreach (var line in lines)
                    {
                        string[] entries = line.Split(',');
                        //Reading from the file ,Splitting up by ',' and storing in the entries array
                        Teacher newTeacher = new Teacher();
                        try
                        {
                            if (entries.Length == 4)
                            {
                                newTeacher.TId = Convert.ToInt32(entries[0]); ;
                                newTeacher.TName = entries[1];
                                newTeacher.Tclass = Convert.ToInt32(entries[2]);
                                newTeacher.Email = entries[3];
                                teachers.Add(newTeacher);
                                Console.WriteLine("\n");
                                Console.WriteLine("=================================================================================================");
                                Console.WriteLine($"ID  {newTeacher.TId} with name {newTeacher.TName} handles {newTeacher.Tclass}th Standard and has contact adress as {newTeacher.Email}");
                            }
                        }
                        catch (OverflowException ex )
                        {

                            Console.WriteLine("Input text on file is not valid"+ ex); 
                        }
                        
                    }
                    break;
                case 2://ADD THE TEACHER DETAIL TO THE TEXT FILE
                    Console.WriteLine("Enter the Teacher Id");
                    int tid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Teacher Name");
                    string tname = Console.ReadLine();
                    Console.WriteLine($"Enter the Class Handled by the {tname} Teacher");
                    int tclass = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the contact adress of {tname}");
                    string temail = Console.ReadLine();
                    teachers.Add(new Teacher { TId = tid,TName=tname,Tclass=tclass,Email=temail });
                    List<string> output = new List<string>();
                    foreach (var item in teachers)
                    {
                        output.Add($"{item.TId},{item.TName},{item.Tclass},{item.Email}");
                    }
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Writing the New Record to the Text File..................");
                    File.AppendAllLines(fpath,output);
                    Console.WriteLine("Succesfully Written the New Teacher Content.");
                    break;
                case 3://Deleting the Teacher Detail
                    Console.WriteLine("Enter The ID of the Teacher to be removed from the file");
                   int tremove = Convert.ToInt32(Console.ReadLine());
                    var file = new List<string>(System.IO.File.ReadAllLines(fpath));
                    
                    
                    file.RemoveAt(tremove-1);
                   File.WriteAllLines(fpath, file.ToArray());

                    break;
                case 4://updating the record
                    Console.WriteLine("fine with 4");
                    break;


                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }

           
        }

        
    }
}
