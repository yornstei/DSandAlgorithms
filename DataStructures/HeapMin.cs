using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class HeapMin
    {
        public int capacity = 10;
        public int size = 0;
        public int[] items;
        public bool printArray = false;

        public HeapMin()
        {
            items = new int[capacity];
        }

        public void Add(int val)
        {
            EnsureCapacity();
            items[size] = val;
            size++;
            HeapifyUp();
        }

        public int Peek()
        {
            if (size == 0) throw new Exception("No Elements");
            return items[0];
        }

        public int Pool()
        {
            if (size == 0) throw new Exception("No Elements");
            int item = items[0];
            items[0] = items[size - 1];
            items[size - 1] = 0;
            size--;
            HeapifyDown();
            return item;
        }

        private void HeapifyDown()
        {
            if (printArray)
            {
                Console.WriteLine("HeapifyDown() Begin");
                PrintHeapArray();
            }

            int index = 0;
            while (HasLeftChild(index))
            {
                if (printArray) PrintHeapArray();

                int smallerChileIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < items[smallerChileIndex])
                    smallerChileIndex = GetRightChildIndex(index);

                if (items[index] < items[smallerChileIndex])
                    break;
                else
                {
                    Swap(index, smallerChileIndex);
                    index = smallerChileIndex;
                }
            }

            if (printArray)
            {
                Console.WriteLine("HeapifyDown() End");
                PrintHeapArray();
            }
        }

        private void HeapifyUp()
        {
            if (printArray)
            {
                Console.WriteLine("HeapifyUp() Begin");
                PrintHeapArray();
            }

            int index = size - 1;
            while (HasParent(index) && items[index] < Parent(index))
            {
                if (printArray) PrintHeapArray();

                Swap(index, GetParentIndex(index));
                index = GetParentIndex(index);
            }

            if (printArray)
            {
                Console.WriteLine("HeapifyUp() End");
                PrintHeapArray();
            }
        }

        private void EnsureCapacity()
        {
            if (size + 1 == capacity)
            {
                int[] newItems = new int[capacity * 2];
                Array.Copy(items, 0, newItems, 0, items.Length);
                capacity *= 2;
                items = newItems;
            }
        }

        public int GetParentIndex(int index) => index / 2;
        public int GetLeftChildIndex(int index) => (index * 2) + 1;
        public int GetRightChildIndex(int index) => (index * 2) + 2;
        public bool HasParent(int index) => GetParentIndex(index) >= 0;
        public bool HasLeftChild(int index) => GetLeftChildIndex(index) < size;
        public bool HasRightChild(int index) => GetRightChildIndex(index) < size;
        public int Parent(int index) => items[GetParentIndex(index)];
        public int LeftChild(int index) => items[GetLeftChildIndex(index)];
        public int RightChild(int index) => items[GetRightChildIndex(index)];
        public void Swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }
        public void PrintHeapArray()
        {
            string s = "";
            items.ToList().ForEach(x => s += x + ",");
            Console.WriteLine(s.TrimEnd(','));
        }
    }
}
