using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class student
    {
        private string name;
        private DateTime dateofbirth;
        private string contactnumber;
        int age = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        bool flag;

        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (age > 18)
        //             flag = true;
        //        else
        //            flag=false;
        //    }
        //}
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        public string ContactNumber
        {
            get { return contactnumber; }
            set { contactnumber = value; }
        }
    }
}
