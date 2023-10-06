using System;

namespace ConsoleAppDell1
{
    public class Node1
    {
        private string data;

        private Node1 next = null;
        private Node1 prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node1 Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node1 Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }

    }
}
