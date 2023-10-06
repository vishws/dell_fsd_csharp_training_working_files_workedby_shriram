////////////// Day 2 -- C# basics 

//////////using System;

//////////namespace ConsoleAppDell1
//////////{
//////////    class Day2_c_prgs
//////////    {
//////////        static void Main(string[] args)
//////////        {
//////////            Day2_c_prgs obj = new Day2_c_prgs();
//////////            obj.datetimedifference();

//////////            Console.ReadLine();
//////////        }
//////////        public void datetimedifference()
//////////        {
//////////            //DateTime d1 = new DateTime(2023, 06, 7);
//////////            //Console.WriteLine(d1);

//////////            //DateTime d2 = new DateTime(2023, 06, 7, 9,20,15);
//////////            //Console.WriteLine(d2);

//////////            //// to print the today's system date and time
//////////            //DateTime today = DateTime.Now;
//////////            //Console.WriteLine(today);

//////////            //DateTime newdate= today.AddDays(10);
//////////            //Console.WriteLine( newdate);

//////////            // program to get the difference between 2 dates 
//////////            DateTime d1 = new DateTime(2023, 01, 07);
//////////            DateTime d2 = new DateTime(2023, 01, 08);

//////////            TimeSpan diff = d2 - d1;
//////////            Console.WriteLine(diff);

//////////            TimeSpan diff1 = d2.Subtract(d1);
//////////            Console.WriteLine(diff1);

//////////            // WAP to accept check in date , checkout date and display the difference
//////////            // in terms of days. 
//////////        }
//////////    }
//////////}


////////////using System;
////////////class Day2_c_prgs
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        function1();

////////////        Day2_c_prgs obj1 = new Day2_c_prgs();
////////////        obj1.function2();

////////////        int result = obj1.add();

////////////        Console.WriteLine("addition result is : "+result);
////////////        Console.ReadLine();
////////////    }

////////////    static void function1()
////////////    {
////////////        Console.WriteLine( "function1()--static is invoked");
////////////    }

////////////    public void function2()
////////////    {
////////////        Console.WriteLine(  "function2() is public --invoked");
////////////    }

////////////    public int add()
////////////    {
////////////        int a = 10;
////////////        int b = 20;
////////////        return(a+b);
////////////    }

////////////}
//////////// 

////////using System;
////////class MyClass
////////{
////////    static void Main(string[] args)
////////    {
////////        MyClass m1 = new MyClass();
////////        m1.doApp();              

////////        Console.ReadLine();
////////    }
////////    public void doApp()
////////    {
////////        DateTime dt= DateTime.Now;
////////        Console.WriteLine(dt);

////////        Console.WriteLine(dt.ToString());

////////        Console.WriteLine("Short date : "+ dt.ToShortDateString());

////////        Console.WriteLine("Short date : " + dt.ToLongDateString());

////////        Console.WriteLine("Customized date format :");

////////        Console.WriteLine( dt.ToString("d"));
////////        Console.WriteLine(dt.ToString("D"));

////////    }
////////}    

//////// working with text
//////// string, stringbuilder

//////using System;
//////using System.Text;

//////class MyClass
//////{
//////    static void Main(string[] args)
//////    {
//////        MyClass m1 = new MyClass();
//////        m1.doApp();

//////        Console.ReadLine();
//////    }
//////    public void doApp()
//////    {

//////        string s1 = "India-is/big-country";
//////        //Console.WriteLine("string is : "+s1);

//////        //Console.WriteLine("Lowercase : "+ s1.ToLower());
//////        //Console.WriteLine("Uppercase : " + s1.ToUpper());

//////        //Console.WriteLine("contains : "+s1.Contains("c"));
//////        //Console.WriteLine("ends with :"+s1.EndsWith("c"));
//////        //Console.WriteLine("substring :" + s1.Substring(0, 5));

//////        //Console.WriteLine("insert string within a string : " + s1.Insert(5, "and US are"));

//////        //splitting

//////        Console.WriteLine( "split a string : ");
//////        string[] parts = s1.Split();

//////        foreach (var item in parts)
//////        {
//////            Console.WriteLine(item);
//////        }

//////        StringBuilder sb = new StringBuilder("");

//////        //for (int i = 0; i < 10; i++)
//////        //{
//////        //    sb.Append(i.ToString() + " ");

//////        //}

//////       // Console.WriteLine( sb);
//////    }
//////}


//////namespace demo


////using ConsoleAppDell1;
////using System;

////namespace A
////{
////	class myclass1
////	{
////		public void function1()
////		{
////            Console.WriteLine("A --myclass1-- function1");
////        }
////	}
////}

////namespace B
////{
////    class myclass2
////    {
////        public void function2()
////        {
////            Console.WriteLine("B --myclass2-- function2");
////        }
////    }
////}


////namespace C
////{
////    class myclass3
////    {
////        public void function3()
////        {
////            Console.WriteLine("C --myclass3-- function3");
////        }
////    }
////}


////namespace D
////{
////	class MyClass
////	{
////		static void Main(string[] args)
////		{
////            A.myclass1 m1 = new A.myclass1();
////            m1.function1();

////            B.myclass2 m2 = new B.myclass2();
////            m2.function2();

////            C.myclass3 m3 = new C.myclass3();
////            m3.function3();

////            namespacedemo1 obj2 = new namespacedemo1();
////            obj2.function4();


////            Console.ReadLine();
////		}
////	}
////}



//// example 2 namespace

//using System;

//// same class names 
//// same function names 
//// different namespaces 

//namespace bangalorewest
//{
//    class canarabank
//    {
//        public void loan()
//        {
//            Console.WriteLine("7.6%");
//        }
//    }

//}
//namespace bangaloreeast
//{
//    class canarabank
//    {
//        public void loan()
//        {
//            Console.WriteLine("7.6%");
//        }
//    }

//}

//class canarabankbranch2
//    {
//        public void loan()
//        {
//            Console.WriteLine("7.7%");
//        }
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //canarabank obj = new canarabank();
//        //obj.loan();

//        //icici obj1 = new icici();
//        //obj1.loan();

//        //AUbank obj2 = new AUbank();
//        //obj2.loan();


//        //bangaloreeast.canarabank branch1 = new bangaloreeast.canarabank();
//        //branch1.loan();

//        //bangalorewest.canarabank branch2 = new bangalorewest.canarabank();
//        //branch2.loan(); 

////        AUbank obj = new AUbank();
////        obj.loan();

////        Console.ReadLine();
////    }
////}