using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class cclas
    {
        public string name;
        private Teacher classteacher;

        private List<student> students;
        private List<subject> subjects;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Teacher ClassTeacher
        {
            get { return classteacher; }
            set { classteacher = value;}
        }

        public List<student> Students
        { 
            get { return students; } 
            set {  students = value; } 
        }

        public List<subject> Subjects
        {
            get { return subjects; }
            set { subjects=value; }
        }

    }
}



// teacher
// subject
// cclass
// student