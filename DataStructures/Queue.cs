using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue
    {
        Node head, tail;

        public bool IsEmpty() => head == null;

        public int Peek()
        {
            if (IsEmpty()) throw new Exception("Empty Queue");
            return head.data;
        }

        public void Add(int x)
        {
            Node newNode = new Node(x);
            if (tail != null) tail.next = newNode;
            tail = newNode;
            if (head == null) head = newNode;
        }

        public int Remove()
        {
            if (IsEmpty()) throw new Exception("Empty Queue");
            int val = head.data;
            head = head.next;
            return val;
        }

        public void Print()
        {
            if (IsEmpty()) throw new Exception("Empty Queue");
            Console.WriteLine("--------");
            Node current = head;
            while(current.next != null)
            {
                Console.Write(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
