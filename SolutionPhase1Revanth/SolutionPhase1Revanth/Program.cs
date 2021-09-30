using System;
using System.Collections.Generic;

namespace SolutionPhase1Revanth
{
    
        class Teacher
        {
            public int Id { get; set; }
            public string tname { get; set; }
            public string tsubject { get; set; }
            public string temail { get; set; }
        }
		class TeacherBO
		{
			public List<Teacher> Teachers { get; set; }
			public TeacherBO()
			{
				Teachers = new List<Teacher>() {
					new Teacher { Id = 1001, tname = "Kiran", tsubject = "Science", temail = "kiran@mail.com" },
					new Teacher { Id = 1002, tname = "Kumar", tsubject = "English", temail = "kumar@mail.com"},
					new Teacher { Id = 1003, tname = "Shivani", tsubject = "Maths", temail = "shivani@mail.com" },
					new Teacher { Id = 1004, tname = "Ankita", tsubject = "Science", temail = "ankita@mail.com" },
					new Teacher { Id = 1005, tname = "Netranand", tsubject = "Social", temail = "netra@mail.com" },
			};
			}
			public List<Teacher> GetAllTeachers()
			{
				return Teachers;
			}
			public void EditRecord()
			{
				Console.WriteLine("Enter the Teacher ID");
				int id = Convert.ToInt32(Console.ReadLine());
				int index = Teachers.FindIndex(x => x.Id == id);
				if (index > 0)
				{
					
					Console.WriteLine("Current Details");
					Console.WriteLine($"{Teachers[index].Id} {Teachers[index].tname} {Teachers[index].tsubject}" +
						$"{Teachers[index].temail}");
					
					Console.WriteLine("Enter new details");
					Console.Write("ID: ");
					Teachers[index].Id = Convert.ToInt32(Console.ReadLine());
					Console.Write("Name: ");
					Teachers[index].tname = Console.ReadLine();
					Console.Write("Subject: ");
					Teachers[index].tsubject = Console.ReadLine();
					Console.Write("Email: ");
					Teachers[index].temail = Console.ReadLine();

				}
				else
				{
					
					Console.WriteLine("Invalid Teacher ID");
					
				}
			}
			public Teacher GetTeacherById(int id)
			{
				return Teachers.Find(x => x.Id == id);
			}

			public void AddTeacher(Teacher temp)
			{
				Teachers.Add(temp);
			}
			public int DeleteRecord(int id)
			{
				int index = Teachers.FindIndex(x => x.Id == id);
				if (index >= 0)
				{
					Teachers.RemoveAt(index);
					return 1;
				}
				else return 0;
			}
		}
	class Program
	{
		static void Main(string[] args)
        {
			TeacherBO context = new TeacherBO();
			Console.WriteLine("1. Add Teacher Details\n2. Edit Teacher details\n" +
				"3. Print all Teacher\n4. Print Teacher details by ID\n" +
				"5. Delete Teacher Record\n6.Exit\n");
			Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            
                switch (choice)
                {
                    case 1:
                       
                        Console.WriteLine("Enter ID, Name, Subject, Email");
                        Teacher temp = new Teacher();
                        temp.Id = Convert.ToInt32(Console.ReadLine());
                        temp.tname = Console.ReadLine();
                        temp.tsubject = Console.ReadLine();
                        temp.temail = Console.ReadLine();
                        context.AddTeacher(temp);
                        
                        break;
                    case 2:
                        context.EditRecord();
                        break;
                    case 3:
                        
                        Console.WriteLine("Teacher Details");
                        List<Teacher> tList = context.GetAllTeachers();
                        foreach (var item in tList)
                        {
                            Console.WriteLine($"{item.Id} {item.tname} {item.tsubject} {item.temail}");
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("Enter Teacher ID");
                        Teacher tmp = context.GetTeacherById(Convert.ToInt32(Console.ReadLine()));
                        if (tmp == null)
                        {
                           
                            Console.WriteLine("Invalid Teacher ID");
                            
                        }
                        else
                        {
                           
                            Console.WriteLine($"{tmp.Id} {tmp.tname} {tmp.tsubject} {tmp.temail}");
                            
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the Teacher ID");
                        int tp = context.DeleteRecord(Convert.ToInt32(Console.ReadLine()));
                        if (tp == 1)
                        {
                           
                            Console.WriteLine("Record Deleted Successfully");
                           
                        }
                        else
                        {
                           
                            Console.WriteLine("Invalid Teacher ID");
                            
                        }
                        break;
                    default:
                        choice = 6;
                        break;
                }
               
            

        }
    }
}
