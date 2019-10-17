using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
