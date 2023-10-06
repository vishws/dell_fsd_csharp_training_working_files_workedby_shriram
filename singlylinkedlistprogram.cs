//using Dell1;
//using System;

//namespace Phase1Section4._7b
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            runApp();
//        }

//        public static void runApp()
//        {
//            SingleLinkedList list = new SingleLinkedList();

//            Node n = new Node();

//            n.Data = "root";

//            list.add(n);

//            for (int i = 0; i < 10; i++)
//            {
//                Node node = new Node();
//                node.Data = Convert.ToString(i);
//                list.add(node);
//            }

//            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

//            n = list.getRoot();

//            while (n != null)
//            {
//                Console.WriteLine(n.Data);
//                n = list.getNext();
//            }

//            Console.ReadLine();
//        }
//    }
//}
