using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCOnsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ServiceReference2.Service1Client obj= new ServiceReference2.Service1Client();
            Console.Write("enter the first number: ");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition result is : " + obj.Addition(n1, n2));
            Console.WriteLine("Substraction result is : " + obj.Substract(n1, n2));
            Console.WriteLine("Multiplcation result is : " + obj.Multiplication(n1, n2));
            Console.WriteLine("Addition result is : " + obj.Division(n1, n2));
            Console.ReadLine();
        }
    }
}
