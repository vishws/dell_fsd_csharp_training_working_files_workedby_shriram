//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppDell1
//{
//     class stackprg
//    {
//        static void Main(string[] args)
//        {
//            //Stack s1= new Stack();
//            //s1.Push(1); 
//            //s1.Push(2);
//            //s1.Push('a');
//            //s1.Push("shriram");

//            //Console.WriteLine("stack elements are : ");
//            //foreach (var item in s1)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //s1.Pop();
//            //Console.WriteLine("stack elements are : ");
//            //foreach (var item in s1)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //Console.WriteLine("count of elements in stack : "+ s1.Count);
//            //Console.WriteLine("top most element in the stack is : "+s1.Peek());

//            //// Queue

//            //Queue q1= new Queue();  
//            //q1.Enqueue(1);
//            //q1.Enqueue(2);
//            //q1.Enqueue(3);  
//            //q1.Enqueue(4);
//            //q1.Enqueue(5);

//            //foreach (var item in q1)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //q1.Dequeue();
//            //foreach (var item in q1)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            ArrayList arr1 = new ArrayList();
//            arr1.Add(10);
//            arr1.Add(20);
//            arr1.Add(30);   // empid =30 -- removed 
//            arr1.Add(40);

//            arr1.Remove(30);


//            Console.WriteLine("Arraylist elements are : ");
//            foreach (var item in arr1)
//            {
//                Console.WriteLine(item);
//            }

//            int[] mahesharr = new int[5] { 2, 3, 4, 5, 6 };

//            arr1.AddRange(mahesharr);

//            Console.WriteLine("Arraylist elements after adding mahesh array are : ");
//            foreach (var item in arr1)
//            {
//                Console.WriteLine(item);
//            }

//            arr1.Sort();
//            Console.WriteLine("Arraylist elements after sorting : ");
//            foreach (var item in arr1)
//            {
//                Console.WriteLine(item);
//            }

//            arr1.Reverse();
//            Console.WriteLine("Arraylist elements after reverse : ");
//            foreach (var item in arr1)
//            {
//                Console.WriteLine(item);
//            }




//            Console.ReadLine();
//        }
//    }
//}
