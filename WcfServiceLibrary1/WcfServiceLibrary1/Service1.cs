using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int Addition( int a , int b )
        { return a + b; }

        public int Substract(int a, int b)
        { return a - b; }
        public int Multiplication(int a, int b)
        { return a * b; }

        public int Division(int a, int b)
        { return a / b; }

    }
}
