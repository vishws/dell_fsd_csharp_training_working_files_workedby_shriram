////// arrays demo
////using System;

////namespace ConsoleAppDell1
////{
////    class c__datastructures_Dell
////    {
////        static void Main(string[] args)
////        {
////            //// single dimensional 
////            //int[] arr= { 1, 2, 3 };

////            //foreach (int i in arr) 
////            //{
////            //    Console.WriteLine( i);
////            //}
////            //=======================================
////            // accept numbers in single dimensional array and display them.

////            //  int[] arr1 = new int[5];
////            //  arr1[0] = 10;
////            //  arr1[1] = 20;
////            //  arr1[2] = 30;
////            //  arr1[3] = 40;
////            //  arr1[4] = 50;
////            ////  arr1[5] = 60;           runtime error

////            //  Console.WriteLine(  "Array elements are : ");
////            //  for (int i = 0; i < arr1.Length; i++)
////            //  {
////            //      Console.WriteLine(arr1[i]);
////            //  }

////            // accept the datas
////            //int[] arr1 = {}  ;

////            //Console.WriteLine("Enter Array elements : ");
////            //for (int i = 0; i < arr1.Length; i++)
////            //{
////            //    arr1[i] = int.Parse(Console.ReadLine());
////            //}


////            //Console.WriteLine("Entered Array elements are: ");
////            //for (int i = 0; i < arr1.Length; i++)
////            //{
////            //    Console.WriteLine(arr1[i]);
////            //}


////            // initialize and display

////            //int[] arr = new int[3] { 1, 2, 3 };

////            //foreach (int i in arr)
////            //{
////            //    Console.WriteLine(i);
////            //}

////            // matrix programs 2x2  3x3 
////            // 


////            //int[] arr = { };  //empty array
////            //int[] numArray = new int[] { 1, 3, 5, 7, 9, 11, 13 };

////            //double dimensional array

////            int[,] arr1 = new int[2,2];
////            int[,] arr2 = new int[2,2];
////            //   0    1
////            //0  8    2 
////            //1  6    1

////            Console.WriteLine("Enter the matrix 1 elements : ");
////            for (int i = 0; i < arr1.GetLength(0); i++)   //row   i=0         i=1
////            {
////                for (int j= 0; j< arr1.GetLength(1); j++)  //column  j=0 j=1  j=0   j=1
////                {
////                    arr1[i,j] = int.Parse(Console.ReadLine());
////                }
////            }

////            Console.WriteLine("matrix 1 is : ");
////            for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            {
////                for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////                {
////                    Console.Write(arr1[i, j]+"     ");
////                }
////                Console.WriteLine(  );
////            }

////            // addition of the matrices 
////            Console.WriteLine("Enter the matrix 2 elements : ");
////            for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            {
////                for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////                {
////                    arr2[i, j] = int.Parse(Console.ReadLine());
////                }
////            }

////            Console.WriteLine("matrix 2 is : ");
////            for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            {
////                for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////                {
////                    Console.Write(arr2[i, j] + "     ");
////                }
////                Console.WriteLine();
////            }

////          //  int[,] resultmatrix=new int[2,2];

////            //Console.WriteLine("Addition of matrices is : ");
////            //// VAR   ----> implicitly typed local variable 
////            //for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            //{
////            //    for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////            //    {
////            //        resultmatrix[i, j] = arr1[i, j] + arr2[i, j];
////            //    }
////            //}

////            //for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            //{
////            //    for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////            //    {
////            //        Console.Write(resultmatrix[i, j] +"    ");
////            //    }
////            //    Console.WriteLine();
////            //}


////            //Console.WriteLine("Multiplication of matrices : ");
////            //for (int i = 0; i < 2; i++)   //row   i=0         i=1
////            //{
////            //    for (int j = 0; j < 2; j++)  //column  j=0 j=1  j=0   j=1
////            //    {
////            //        for(int k=0;k<2;k++)
////            //        {
////            //                              }
////            //        resultmatrix[i, j] = arr1[i, j] * arr2[i, j];
////            //    }
////            //}
////            Console.ReadLine();
////        }
////    }
////}

////===============================================================================

//// singly linked list program

//using System;
//using System.Collections.Generic;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //List<int> list = new List<int>();
//        //list.Add(1);
//        //list.Add(2);
//        //list.Add(3);
//        //list.Add(4);    
//        //list.Add(5);
       
//        //Console.WriteLine("List elements are : ");
//        //foreach (var item in list)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //list.RemoveAt(0);
//        //Console.WriteLine("List elements are : ");
//        //foreach (var item in list)
//        //{
//        //    Console.WriteLine(item);
//        //}

       

//        Console.ReadLine(); 
//    }
//}