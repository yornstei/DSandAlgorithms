using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Stopwatch stopwatch = new Stopwatch();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //int count = Recursion.CountOfTxtFilesInDir(path);
            //Console.WriteLine($@"Txt file count in dir {path} = {count}");

            //Recursion.PrintTxtFilesInDir(@"C:\Users\yornstein\Desktop");

            //stopwatch.Start();
            //Console.WriteLine($"Fib(5) = {Memoization.FibRecursion(5)}");
            //Console.WriteLine($"Fib(9) = {Memoization.FibRecursion(9)}");
            //Console.WriteLine($"Fib(15) = {Memoization.FibRecursion(15)}");
            //Console.WriteLine($"Fib(35) = {Memoization.FibRecursion(35)}");
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);


            //stopwatch.Reset();
            //stopwatch.Start();
            //Console.WriteLine($"Fib(5) = {Memoization.FibMemoized(5)}");
            //Console.WriteLine($"Fib(9) = {Memoization.FibMemoized(9)}");
            //Console.WriteLine($"Fib(15) = {Memoization.FibMemoized(15)}");
            //Console.WriteLine($"Fib(35) = {Memoization.FibMemoized(35)}");
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);

            //int[,] grid = new int[,] 
            //{
            //    {0, 0, 0, 0, 0, 0, 0, 0},
            //    {0, 0, 1, 0, 0, 0, 1, 0},
            //    {0, 0, 0, 0, 1, 0, 0, 0},
            //    {1, 0, 1, 0, 0, 1, 0, 0},
            //    {0, 0, 1, 0, 0, 0, 0, 0},
            //    {0, 0, 0, 1, 1, 0, 1, 0},
            //    {0, 1, 0, 0, 0, 1, 0, 0},
            //    {0, 0, 0, 0, 0, 0, 0, 0},
            //};

            //Console.WriteLine($"PathsCount Recursion {DynamicProgramming.PathsCountRecursion(grid, 0, 0)}");
            //Console.WriteLine($"PathsCount Memoized {DynamicProgramming.PathsCountMemoized(grid, 0, 0)}");
            //Console.WriteLine($"PathsCount DynamicProg {DynamicProgramming.PathsCountDynamicProg(grid, 0, 0)}");

            //Console.ReadKey();

            //int[] nums = new int[] { 2, 3, 4, 5, 6, 7, 8, 10, 11, 14, 16 };
            //int[] nums2 = new int[] { 1, 3, 4, 5, 7, 8, 10, 12, 15, 18, 21, 22, 25 };

            //Console.WriteLine(Search.BinarySearchRecursion(nums, 9));
            //Console.WriteLine(Search.BinarySearchRecursion(nums2, 5));
            //Console.WriteLine(Search.BinarySearchRecursion(nums, 9, 0, nums.Length - 1));
            //Console.WriteLine(Search.BinarySearchRecursion(nums2, 5, 0, nums2.Length - 1));
            //Console.WriteLine(Search.BinarySearchLoop(nums, 9));
            //Console.WriteLine(Search.BinarySearchLoop(nums2, 5));

            //Random random = new Random();
            //int[] numbers = new int[1000];
            //for (int i = 0; i < 999; i++)
            //{
            //    int rand = random.Next(1, 10000);
            //    if (rand != 455)
            //        numbers[i] = rand;
            //}

            //int value = numbers[501];

            //Array.Sort(numbers);

            //Console.WriteLine(Search.BinarySearchRecursion(numbers, value));
            //Console.WriteLine(Search.BinarySearchRecursion(numbers, 455));
            //Console.WriteLine(Search.BinarySearchRecursion(numbers, value, 0, numbers.Length - 1));
            //Console.WriteLine(Search.BinarySearchRecursion(numbers, 455, 0, numbers.Length - 1));
            //Console.WriteLine(Search.BinarySearchLoop(numbers, value));
            //Console.WriteLine(Search.BinarySearchLoop(numbers, 455));

            //Console.ReadKey();

            int[] arr = new int[] { 4, 6, 3, 2, 7, 1, 5, 9, 8 };
            arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine();

            Sort.BubbleSort(arr);
            arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine("\n---------");

            arr = new int[] { 4, 6, 3, 2, 7, 1, 5, 9, 8, 10 };
            arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine();

            Sort.MergeSort(arr);
            arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine("\n---------");

            arr = new int[] { 4, 6, 3, 2, 7, 1, 5, 9, 8, 10 };
            arr.ToList().ForEach(x => Console.Write(x));

            Console.WriteLine();

            Sort.QuickSort(arr);
            arr.ToList().ForEach(x => Console.Write(x));
        }
    }
}
