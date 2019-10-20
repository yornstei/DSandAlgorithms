using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        public int id;
        public Node next;

        public Node(int id)
        {
            this.id = id;
        }
    }

    class LinkedList
    {
        Node head;

        public LinkedList() { }
        public LinkedList(int x)
        {
            head = new Node(x);
        }

        public void Insert(int x)
        {
            if (head == null)
                head = new Node(x);
            else
            {
                Node nNode = new Node(x);
                nNode.next = head;
                head = nNode;
            }
        }

        public void Append(int x)
        {
            if (head == null)
                head = new Node(x);
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = new Node(x);
            }
        }

        public void Delete()
        {
            if (head == null) return;
            if (head.next == null)
            {
                head = null;
                return;
            }

            Node temp = head;
            while (temp.next.next != null)
                temp = temp.next;
            temp.next = null;
        }

        public bool Delete(int x)
        {
            if (head == null) return false;
            else if (head.id == x)
            {
                head = head.next;
                return true;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.id == x)
                {
                    current.next = current.next.next;
                    return true;
                }
                else current = current.next;
            }

            return false;
        }

        public void Clear() => head = null;

        public void PrindList()
        {
            Console.WriteLine("---------------");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.id);
                temp = temp.next;
            }
            Console.WriteLine("");
        }
    }
}
