//using System;
//using System.Collections.Generic;
//using System.Text;
//using ConsoleAppDell1;

//namespace Phase1Section4._7c
//    {
//        public class DoubleLinkedList
//        {
//            private Node1 root = null;
//            private Node1 current = null;
//            private int length;

//            public Node1 Root
//            {
//                get { return this.root; }
//                set { this.root = value; }
//            }

//            public int Length
//            {
//                get { return this.length; }
//                set { this.length = value; }
//            }

//            public void add(Node1 node)
//            {
//                node.Next = null;

//                if (root == null)
//                {
//                    root = node;
//                    length = 1;
//                    current = root;
//                    root.Prev = null;
//                }
//                else
//                {
//                    current.Next = node;
//                    node.Prev = current;
//                    current = node;
//                    length++;
//                }
//            }

//            public Node1 getCurrent()
//            {
//                return this.current;
//            }

//            public Node1 getRoot()
//            {
//                current = root;
//                return this.root;
//            }

//            public Node1 getNext()
//            {
//                if (current.Next != null)
//                {
//                    current = current.Next;
//                    return current;
//                }
//                else
//                    return null;
//            }

//            public Node1 getPrev()
//            {
//                if (current.Prev != null)
//                {
//                    current = current.Prev;
//                    return current;
//                }
//                else
//                    return null;
//            }

//            public int getLengthOfList()
//            {
//                return this.length;
//            }
//        }
//    }

