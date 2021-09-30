using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    //creating and writing into file
    /*
    class program25
    {
         static void Main(string[] args)
         {
             string fpath = @"D:\myfile.txt";
             StreamWriter fname = new StreamWriter(fpath);
             fname.WriteLine("Welcome to file handling");
             fname.WriteLine("file created from c");
             fname.WriteLine("Created by revu at"+ DateTime.Now);

             Console.WriteLine("File created succesfully.....");
             fname.Close();

         }
        
    class program25
    {
        //reading from the file and displaying on console window
        static void Main(string[] args)
        {
            string fpath = @"D:\myfile.txt";
            StreamReader sr = new StreamReader(fpath);
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
        }
    //if file is not found then go for try catch block
            string fpath = @"e:\myfile1.txt";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fpath);
                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch ( FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                Console.WriteLine($"{fpath} not exist...");
            }
            sr.Close();
    }
    
    //adding content to the existing file
    class program25
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\myfile.txt";
            FileStream fname = new FileStream(fpath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fname);
            sw.WriteLine("Added at EOF at " + DateTime.Now);
            sw.Close();
            Console.WriteLine("written Successfully");
        }
    }
    */
    //getting the file path
    class program25
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\myfile.txt";
            //total file path
            Console.WriteLine("path=  "+Path.GetDirectoryName(fileName));
            //file path with file name
            Console.WriteLine("Path=  "+ Path.GetFullPath(fileName));
            //returns extension of path file
            Console.WriteLine("extension of the path  "+Path.GetExtension(fileName));
            //return filename of path
            Console.WriteLine("Filename of path =  "+Path.GetFileName(fileName));
            var file = new List<string>(System.IO.File.ReadAllLines(fileName));
            file.RemoveAt(1);
            File.WriteAllLines(fileName, file.ToArray());

        }
    }

}
/*
 IO stands for Input and Output
.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:    This is the feature used to handle files like
    Write data, read data, delete file, etc.,
To create Object:
StreamWriter obj = new StreamWrite("filename");
Note: The above system will create a new file, overwrite if file already exist
StreamWriter obj = new StreamWrite("filename",true);
By providing true as second parameter, the data will into the content
 */
/*
StreamReader object, contains methods usedto read content from the existing file
 */