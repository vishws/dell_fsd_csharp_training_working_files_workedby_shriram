// example 2 : class demo

using System;

namespace ConsoleApp2
{
   public class subject
    {
        string name;
        string shortname;

        // user defined properties 
        // get --read only
        // set -- write only
        // get, set : read write property
        // get; set;   automatic property 
        public string Name
        {
            get
            {
                return name;
            }   //accessors 
            set
            {
                name = value;
            }
        }

        public string ShortName
        {
            get
            {
                return shortname;
            }   //accessors 
            set
            {
                shortname = value;
            }
        }

    }
}
