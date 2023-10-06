//using ConsoleAppDell1;
//using System;

//namespace Phase1Section4._7c
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            runApp();
//        }

//        public static void runApp()
//        {
//            DoubleLinkedList list = new DoubleLinkedList();

//            Node1 n = new Node1();

//            n.Data = "root";

//            list.add(n);

//            for (int i = 0; i < 10; i++)
//            {
//                Node1 node = new Node1();

//                node.Data = Convert.ToString(i);

//                list.add(node);
//            }

//            Console.WriteLine("length of doubly linked list=" + list.getLengthOfList());
//            Console.WriteLine("Traversing forward..");

//            n = list.getRoot();
//            while (n != null)
//            {
//                Console.WriteLine(n.Data);
//                n = list.getNext();
//            }


//            Console.WriteLine("Traversing backwards..");
//            n = list.getPrev();

//            while (n != null)
//            {
//                Console.WriteLine(n.Data);
//                n = list.getPrev();
//            }

//            Console.ReadLine();
//        }
//    }
//}
