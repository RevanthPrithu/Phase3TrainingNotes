using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TrainingPhase1_ProjectSolution
{
   
    class Program
    {
        static void Main(string[] args)
        {         
            string fpath = @"D:\myfile.txt";
            List<TeacherRecord> teachers = new List<TeacherRecord>();
            Console.WriteLine("What Operation do you need to perform on the Teacher database?:Choose(1/2/3/4/5)");
            Console.WriteLine("1.Get The Record \n2.Add the Teacher Detail \n3. Delete Teacher Detail \n4.Get Teacher Record through ID\n5.Update the Teacher Detail");
            int Key = System.Convert.ToInt32(Console.ReadLine());
            switch (Key)
            {
                case 1:
                    
                    //GET THE TEACHER RECORD ON CONSOLE WINDOW
                    List<string> lines = File.ReadAllLines(fpath).ToList();
                    foreach (var line in lines)
                    {
                        string[] entries = line.Split(',');
                        //Reading from the file ,Splitting up by ',' and storing in the entries array
                        TeacherRecord newTeacher = new TeacherRecord();
                        try
                        {
                            if (entries.Length == 4)
                            {
                                newTeacher.Id = Convert.ToInt32(entries[0]); ;
                                newTeacher.TName = entries[1];
                                newTeacher.Sub =entries[2];
                                newTeacher.email = entries[3];
                                teachers.Add(newTeacher);
                                Console.WriteLine("\n");
                                Console.WriteLine("================================================================================================================================");
                                Console.WriteLine($"ID  {newTeacher.Id} with name {newTeacher.TName} handles {newTeacher.Sub} Subject and has contact address as {newTeacher.email}");
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("Input text on file is not valid" + ex);
                        }
                    }
                    break;

                case 2:
                    
                    //ADD THE TEACHER DETAIL TO THE TEXT FILE
                    Console.WriteLine("Enter the Teacher Id");
                    int tid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Teacher Name");
                    string tname = Console.ReadLine();
                    Console.WriteLine($"Enter the subject Handled by the {tname} Teacher");
                    string tsub = Console.ReadLine();
                    Console.WriteLine($"Enter the contact adress of {tname}");
                    string temail = Console.ReadLine();
                    teachers.Add(new TeacherRecord { Id = tid, TName = tname, Sub = tsub, email = temail });
                    List<string> output = new List<string>();
                    foreach (var item in teachers)
                    {
                        output.Add($"{item.Id},{item.TName},{item.Sub},{item.email}");
                    }
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Writing the New Record to the Text File..................");
                    File.AppendAllLines(fpath, output);
                    Console.WriteLine("Succesfully Written the New Teacher Content.");
                    break;

                case 3:
                                        
                    //DELETING A TEACHER DETAIL
                    Console.WriteLine("Enter The ID of the Teacher to be removed from the file");
                    string tremove = Console.ReadLine();
                    try
                    {
                        List<string> files = new List<string>(System.IO.File.ReadAllLines(fpath));
                        List<string> newfile = new List<string>();
                        foreach (var item in files)
                        {
                            if (item.StartsWith(tremove))
                            {
                              //DO NOTHING 
                            }
                            else
                            { 
                                newfile.Add(item);
                                File.WriteAllLines(fpath, newfile.ToArray());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Occurred" + ex.Message);
                    }
                    break;

                case 4:

                    //GETTING TEACHER DATA BY ID
                    Console.WriteLine("Enter The ID of the Teacher to obtain the data");
                    string tdata = Console.ReadLine();
                    List<string> file = new List<string>(System.IO.File.ReadAllLines(fpath));
                    foreach (var item in file)
                    {
                        if (item.StartsWith(tdata))
                        {
                            string[] entries = item.Split(',');
                            TeacherRecord entry = new TeacherRecord();
                            entry.Id = Convert.ToInt32(entries[0]);
                            entry.TName = entries[1];
                            entry.Sub = entries[2];
                            entry.email = entries[3];
                            Console.WriteLine($"ID  {entry.Id} with name {entry.TName} handles {entry.Sub} Subject and has contact address as {entry.email}");
                        }
                    }
                    break;

                case 5: 

                    //UPDATING TEACHER DETAIL
                    Console.WriteLine("Enter The ID of the Teacher to update the data");
                    string tupdate = Console.ReadLine();
                    List<string> update = new List<string>(System.IO.File.ReadAllLines(fpath));
                    List<string> updated = new List<string>();
                    foreach (var item in update)
                    {
                        if (item.StartsWith(tupdate))
                        {                           
                            TeacherRecord entry = new TeacherRecord();
                            Console.WriteLine("Enter the Information of Updation)");
                            Console.WriteLine("================================================");
                            Console.WriteLine("Enter Teacher Name");
                            string name = Console.ReadLine();
                            Console.WriteLine($"Enter the subject Handled by the {name} Teacher");
                            string sub = Console.ReadLine();
                            Console.WriteLine($"Enter the contact address of {name}");
                            string tmail = Console.ReadLine();
                            teachers.Add(new TeacherRecord { Id = Convert.ToInt32(tupdate), TName = name, Sub = sub, email = tmail });
                            foreach (var items in teachers)
                            {
                                updated.Add($"{items.Id},{items.TName},{items.Sub},{items.email}");
                            }
                            File.WriteAllLines(fpath, updated.ToArray());
                        }
                        else
                        {
                            updated.Add(item);
                            File.WriteAllLines(fpath, updated.ToArray());
                        }
                       
                    }
                    break;

                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
    }
}