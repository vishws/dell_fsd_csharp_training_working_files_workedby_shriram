using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqconsole
{
    public class linqclass
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public static List<linqclass> getlinqattribute()
        {

            List<linqclass> linqclass = new List<linqclass>()
            {
                new linqclass { ID = 1, name = "Ram", salary = 9000 },
                new linqclass { ID = 2, name = "Shriram", salary = 12000 },
                new linqclass { ID = 3, name= "Shri" , salary = 15000 }


            };

            return linqclass;
        }

        public static void Main(string[] args)

        {
            //basic program
            /*
             int[] arr11 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
             //using  methos syntax

             int addition1 = arr11.Sum();
             Console.WriteLine("addition using method syntax : " + addition1);

             //using  query syntax

             int addition2 = (from i in arr11
                              select i).Sum();

             Console.WriteLine("addition using query syntax : " + addition2);

             Console.ReadLine(); 
            */

            //program with list object which we generally use in our web form or mvc during web development

            //query syntaxx
            var add1 = (from emp in linqclass.getlinqattribute()
                        select emp).Sum(x => x.salary);

            
            var add2 = (from emp in linqclass.getlinqattribute()
                        select emp).Sum(emp => emp.salary);

            var addwithcondition = (from emp in linqclass.getlinqattribute()
                                    where emp.salary > 10000
                                    select emp);

            List<linqclass> add3 = (from emp in linqclass.getlinqattribute()
                                    select emp).ToList();

            Console.WriteLine("addwithcondition output");
            foreach (linqclass item in addwithcondition)
            {
               
                Console.WriteLine("id : " + item.ID + " name : {0} " + item.name + " salary :  {0}" + item.salary);
            }

            Console.WriteLine("addwithlist output(query syntx)");
            foreach (linqclass item in add3)
            {
                Console.WriteLine("id : "+ item.ID + " name : " +  item.name + " salary:  "+item.salary);
            }

            //method syntax

            IEnumerable<linqclass> add4 = linqclass.getlinqattribute().ToList();
            Console.WriteLine("addwithlist output (method syntax)");
            foreach (linqclass item in add4)
            {
                Console.WriteLine("id :" + item.ID + " name :" + item.name + " salary " + item.salary);
            }

            //Console.WriteLine("sum1 :" + add1);
            //Console.WriteLine("sum2 :" + add1);

        }




    }
}
