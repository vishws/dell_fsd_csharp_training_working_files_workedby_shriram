using System;
using System.Collections.Generic;
using System.Text;

// access specifieres : private, public, protected
// internal, protected internal 

namespace ConsoleApp2
{
    public class Teacher
    {
        private string name;
        private string address;
        private string contactaddress;
        private DateTime dateofjoining;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address;}
            set { address = value; }
        }

        public string ContactAddress
        {
            get;set;
        }

        public DateTime Dateofjoining
        { 
            get { return dateofjoining;} 
            set {  dateofjoining = value; } 
        }       
    }
}

