//////c# basics program
////using System;

////     class secondprg
////    {
////        static void Main()
////        {
////        // if... 
////        // if...else
////        // if...else if...else if....

////        //Console.WriteLine("Enter your name : ");
////        //string name = Console.ReadLine();

////        //if (name =="Jyoti")
////        //    Console.WriteLine(  "welcome");
////        //else
////        //    Console.WriteLine( "bye");
//////==========================================================================================
////        // calculator program 
////        Console.WriteLine("Enter first number : ");
////        int num1= int.Parse(Console.ReadLine());

////        Console.WriteLine("Enter second number : ");
////        int num2 = int.Parse(Console.ReadLine());

////        Console.WriteLine("Enter operator : (+ , - , *, /, %)");
////        char op = char.Parse( Console.ReadLine());

////        //if ( op=='+')
////        //{
////        //    Console.WriteLine("Addition result is : "+(num1+num2));
////        //}
////        //else if (op == '-')
////        //{
////        //    Console.WriteLine("subtraction result is : " + (num1 - num2));
////        //}
////        //else if (op == '*')
////        //{
////        //    Console.WriteLine("Multiplication result is : " + (num1 * num2));
////        //}
////        //else if (op == '/')
////        //{
////        //    Console.WriteLine("Division result is : " + (num1 / num2));
////        //}
////        //else if (op == '%')
////        //{
////        //    Console.WriteLine("Modulus result is : " + (num1 % num2));
////        //}

////        switch (op)
////        {
////           // case 1:
////           // case "Dell"
////           // case 1.1 
////           // case 'a'

////            case '+': Console.WriteLine("Addition result is : " + (num1 + num2));
////                break;
////            case '-':
////                Console.WriteLine("Subtraction result is : " + (num1 - num2));
////                break;
////            case '*':
////                Console.WriteLine("Multiplication result is : " + (num1 * num2));
////                break;
////            case '/':
////                Console.WriteLine("Division result is : " + (num1 / num2));
////                break;
////            case '%':
////                Console.WriteLine("Modulus result is : " + (num1 % num2));
////                break;

////            default: Console.WriteLine("this default section will always execute");
////                break;
////        }


////        Console.ReadLine();
////    }
////    }


//// loops demo
////using System;

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        //for loop
////        Console.WriteLine(  "For loop demo :");
////        for(int i = 1; i <= 50; i++) 
////        {
////            Console.Write( i +"  ");
////        }
////        Console.WriteLine(  );
////        Console.WriteLine("For loop demo (for displaying even numbers ):");
////        for (int i = 0; i <= 50; i=i+2)
////        {
////            Console.Write(i + "  ");
////        }

////        Console.WriteLine();
////        Console.WriteLine("For loop demo (for displaying odd numbers ):");
////        for (int i = 1; i <= 50; i = i + 2)
////        {
////            Console.Write(i + "  ");
////        }

////        Console.WriteLine();
////        Console.WriteLine("For loop demo (for displaying odd numbers ):");
////        for (int i = 1; i <= 50; i++)
////        {
////            if (i % 2 != 0)
////            {
////                Console.Write(i + "  ");
////            }
////        }

////        Console.WriteLine();
////        Console.WriteLine("For loop demo (for displaying even numbers ):");
////        for (int i = 1; i <= 50; i++)
////        {
////            if (i % 2 == 0)
////            {
////                Console.Write(i + "  ");
////            }
////        }

////        // display all numbers which are divisible by 5 
////        Console.WriteLine("numbers divisible by 5 :");
////        for (int i = 1; i <= 50; i++)
////        {
////            if (i % 5 == 0)
////            {
////                Console.Write(i + "  ");
////            }
////        }

////        Console.WriteLine(  ); Console.WriteLine(   );

////        //while loop 
////        Console.WriteLine("While loop demo : ");
////        int a = 100;
////        while (a<50)
////        {
////            Console.Write(a+" ");
////            a++;
////        }

////        //do....while loop 
////        Console.WriteLine("do While loop demo : ");
////        int b = 10;

////        do
////        {
////            Console.WriteLine("WELCOME TO DELL BATCH");

////        } while (b==100);



////        Console.ReadLine();
////    }
////}

////GOTO STATEMENT DEMO
//using System;
//using System.Diagnostics;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //goto demo
//        Console.WriteLine(  "Goto demo :");
//        for (int i = 0; i < 10; i++)
//        {
//            if (i == 5)
//                goto dell;

//            Console.WriteLine("This statement will never execute");
//        }

//        dell:
//            for (int i = 0;i<5 ; i++)
//             {
//               Console.WriteLine(  i);
//             }


//        //xxxxxxxxxxxxxxxxxxxxxxxxxxxx not works
//        //for (int i = 0; i < 5; i++)
//        //{
//        //    dell:
//        //    Console.WriteLine("Welcome");
//        //    Console.WriteLine("to Dell ");
//        //    Console.WriteLine("Bangalore");

//        //}

//        Console.ReadLine();
//    }
//}
