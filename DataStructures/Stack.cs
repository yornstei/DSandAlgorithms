using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack
    {
        Node top;

        public bool IsEmpty() => top == null;

        public int Peek()
        {
            if (IsEmpty()) throw new Exception("Empty Stack");
            return top.data;
        }

        public void Push(int x)
        {
            Node newNode = new Node(x);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new Exception("Empty Stack");
            int val = top.data;
            top = top.next;
            return val;
        }

        public void Print()
        {
            if (IsEmpty()) throw new Exception("Empty Stack");
            Console.WriteLine("--------");
            Node temp = top;
            while (temp.next != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}
