using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    //todo: look into balancing a BST
    class BSTree
    {
        public BSTree left, right;
        public int data;
        public BSTree(int d)
        {
            data = d;
        }

        public void Insert(int value)
        {
            if(value <= data)
            {
                if (left == null)
                    left = new BSTree(value);
                else
                    left.Insert(value);
            }
            else
            {
                if (right == null)
                    right = new BSTree(value);
                else
                    right.Insert(value);
            }
        }

        public bool Contains(int value)
        {
            if (data == value) return true;
            if (value < data && left != null)
                return left.Contains(value);
            else if (value > data && right != null)
                return right.Contains(value);

            return false;
        }

        public void PrintInOrder()
        {
            if (left != null)
                left.PrintInOrder();

            Console.WriteLine(data);

            if (right != null)
                right.PrintInOrder();
        }
    }
}
