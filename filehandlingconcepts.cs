// file handling concepts in c#
using System;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleAppDell1
{
    class filehandlingconcepts
    {
        static void Main(string[] args)
        {
            filehandlingconcepts obj = new filehandlingconcepts();
            obj.doApp();    

            Console.ReadLine();
        }

        public void doApp()
        {
            //FileInfo f1 = new FileInfo("C:\\Users\\Asus\\demo\\csharpprgsDell\\day2c#prgs.txt");
            //// path --dotnet   include   @"   or \\ within the path
            //Console.WriteLine(f1.FullName);
            //Console.WriteLine(f1.CreationTime.ToString());
            //Console.WriteLine(f1.LastWriteTime.ToString());
            //Console.WriteLine(f1.Extension);
            //Console.WriteLine(f1.Length);

            //DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\Asus\\demo\\csharpprgsDell");
            //Console.WriteLine(directoryInfo.FullName);
            //Console.WriteLine(directoryInfo.CreationTime.ToString());
            //Console.WriteLine(directoryInfo.LastWriteTime.ToString());
            //Console.WriteLine(directoryInfo.Extension);




            //Console.WriteLine("to display all sub directories:"); 
            //string root = "C:\\Users\\Asus\\demo";

            //string[] dirnames= Directory.GetDirectories(root);
            //foreach (string dirname in dirnames)
            //{
            //    Console.WriteLine(dirname);
            //}

            ////=================================================================
            //Console.WriteLine("Display all files : ");
            //string root1 = "C:\\Users\\Asus\\demo";

            //string[] filenames = Directory.GetFiles(root);
            //foreach (string fname in filenames)
            //{
            //    Console.WriteLine(fname);
            //}

            //Directory.CreateDirectory("c:\\users\\asus\\demo\\dell");

            // stream reader 
            // stream writer


            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";

            if (File.Exists(filename))
            {
                Console.WriteLine(filename + "exists");
            }
            else
            {
                Console.WriteLine(filename + "does not exist");
            }

            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("first line");
                sw.WriteLine("second line");
                sw.WriteLine("third line");
                sw.WriteLine("fourth line");
                sw.WriteLine("fifth line");
            }

            Console.WriteLine(filename +"  created");

            //string[] lines1= File.ReadAllLines(filename);
            //foreach (var item in lines1)
            //{
            //    Console.WriteLine(item);
            //}

            //string lines2 = File.ReadAllText(filename);
            //Console.WriteLine(lines2);

            using (StreamReader rdr = File.OpenText("c:\\demo123\\file1.txt"))
            {
                string t = null;

                while((t=rdr.ReadLine()) != null)                 
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine(  );
            }

           // using (SqlConnection con=...................)

        }
    }
}
