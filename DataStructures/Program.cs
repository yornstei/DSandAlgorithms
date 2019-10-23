using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO
            Queue queue = new Queue();
            Console.WriteLine(queue.IsEmpty());
            queue.Add(1);
            queue.Add(3);
            queue.Print();
            Console.WriteLine(queue.Peek());
            queue.Add(5);
            queue.Add(2);
            queue.Print();
            queue.Remove();
            queue.Print();

            //LIFO
            Stack stack = new Stack();
            Console.WriteLine(stack.IsEmpty());
            stack.Push(1);
            stack.Push(3);
            stack.Print();
            Console.WriteLine(stack.Peek());
            stack.Push(5);
            stack.Push(2);
            stack.Print();
            stack.Pop();
            stack.Print();

            Console.ReadKey();

            LinkedList linkedList = new LinkedList(1);
            linkedList.PrindList();
            linkedList.Delete();
            linkedList.Append(2);
            linkedList.PrindList();
            linkedList.Append(4);
            linkedList.Append(10);
            linkedList.PrindList();
            linkedList.Delete();
            linkedList.PrindList();

            linkedList.Clear();
            linkedList.PrindList();

            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(10);
            linkedList.PrindList();
            linkedList.Delete(4);
            linkedList.PrindList();

            linkedList.Clear();
            linkedList.PrindList();

            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(10);
            linkedList.PrindList();
            linkedList.Delete(2);
            linkedList.PrindList();

            linkedList.Clear();
            linkedList.PrindList();

            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(10);
            linkedList.PrindList();
            linkedList.Delete(10);
            linkedList.PrindList();

            Console.ReadKey();

            Console.WriteLine("Hello World!");

            HeapMin heapMin = new HeapMin();
            heapMin.printArray = true;
            heapMin.Add(3);
            heapMin.Add(4);
            heapMin.Add(8);
            heapMin.Add(1);
            heapMin.Add(7);
            heapMin.Add(2);
            heapMin.Add(5);

            int min = heapMin.Peek();
            Console.WriteLine(min); // should == 1
            heapMin.Pool();
            heapMin.Pool();
            heapMin.Pool();
            min = heapMin.Peek();
            Console.WriteLine(min); // should == 4


            Console.ReadKey();

            BSTree bSTree = new BSTree(10);
            bSTree.Insert(15);
            bSTree.Insert(5);
            bSTree.PrintInOrder();
            bSTree.Insert(8);
            bSTree.PrintInOrder();
            Console.WriteLine(bSTree.Contains(8));
            Console.WriteLine(bSTree.Contains(18));


            Console.ReadKey();
        }
    }
}
