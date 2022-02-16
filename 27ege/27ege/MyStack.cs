using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ege
{
    class MyStack
    {
        private class Node
        {
            public int data;
            public Node next = null;

            public Node(int data, Node next = null)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node head;

        public MyStack()
        {
            head = null;
        }

        public void Push(int n)
        {
            if (head == null)
            {
                head = new Node(n);
                return;
            }

            var oldHead = head;
            head = new Node(n, oldHead);
        }

        public int Peek()
        {
            if (head == null)
            {
                return -1;
            }

            return head.data;
        }

        public int Pop()
        {
            if (head == null)
            {
                return -1;
            }

            int res = head.data;
            head = head.next;
            return res;
        }
    }
}
