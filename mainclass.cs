using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2
{
    public class mainclass
    {
        static void Main(string[] args)
        {

            //student obj = new student();

            //obj.Name = "Test";
            //obj.ContactNumber = "12312";
            //obj.DateOfBirth = DateTime.Now;

            //Console.WriteLine(obj.Name);
            //Console.WriteLine(obj.ContactNumber);
            //Console.WriteLine(obj.DateOfBirth);


            app();

        }

        public static void app()
        {
            string[] arrsubjects = { "English", "Physics", "chemistry", "biology", "Maths" };
            string[] arrshornames= { "Eng", "Phy", "che", "bio", "Math" };

            string[] arrstudents = { "anil", "akash", "sravani", "anant", "brahma" };

            List<student> liststudents = new List<student>();
            List<subject> listsubjects = new List<subject>();

            subject obj = new subject();

            for (int i = 0; i < arrsubjects.Length; i++)
            {               
                obj.Name = arrsubjects[i];
                obj.ShortName = arrshornames[i];

                listsubjects.Add(obj);
            }


            student studobj = new student();
            for (int i = 0; i < arrstudents.Length; i++)
            {
                studobj.Name = "poonam";
                studobj.ContactNumber = "89898";
                studobj.DateOfBirth = DateTime.Now;

                liststudents.Add(studobj);                
            }
            
            Teacher classteacher = new Teacher();
            classteacher.Name = "Mrs.Radha";
            classteacher.Address = "Bangalore";

            cclas objcclass = new cclas();
            objcclass.Name = "Std 4";
            objcclass.Students=liststudents;
            objcclass.Subjects=listsubjects;

            objcclass.ClassTeacher= classteacher;
            
            Console.WriteLine(liststudents);
            Console.WriteLine(listsubjects);

            //foreach (var item in liststudents)         xxxxxxxxxxxxxx
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.ContactNumber);
            //    Console.WriteLine(item.DateOfBirth);               
            //}

            //foreach (var item in listsubjects)         xxxxxxx
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.ShortName);         

            //}

            Console.WriteLine("List of students : ");
            for (int i = 0; i < liststudents.Count; i++)
            {
                Console.WriteLine(liststudents[i].Name);
                Console.WriteLine(liststudents[i].ContactNumber);
            }

            Console.WriteLine("List of subjects : ");
            for (int i = 0; i < listsubjects.Count; i++)
            {
                Console.WriteLine(listsubjects[i].Name);
                Console.WriteLine(listsubjects[i].ShortName);
            }

            Console.ReadLine();

        }


    }
}
