using System;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //int count = Recursion.CountOfTxtFilesInDir(path);
            //Console.WriteLine($@"Txt file count in dir {path} = {count}");

            //Recursion.PrintTxtFilesInDir(@"C:\Users\yornstein\Desktop");

            stopwatch.Start();
            Console.WriteLine($"Fib(5) = {Memoization.FibRecursion(5)}");
            Console.WriteLine($"Fib(9) = {Memoization.FibRecursion(9)}");
            Console.WriteLine($"Fib(15) = {Memoization.FibRecursion(15)}");
            Console.WriteLine($"Fib(35) = {Memoization.FibRecursion(35)}");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);


            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine($"Fib(5) = {Memoization.FibMemoized(5)}");
            Console.WriteLine($"Fib(9) = {Memoization.FibMemoized(9)}");
            Console.WriteLine($"Fib(15) = {Memoization.FibMemoized(15)}");
            Console.WriteLine($"Fib(35) = {Memoization.FibMemoized(35)}");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            int[,] grid = new int[,] 
            {
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 0, 0, 0},
                {1, 0, 1, 0, 0, 1, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 0, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
            };

            Console.WriteLine($"PathsCount Recursion {DynamicProgramming.PathsCountRecursion(grid, 0, 0)}");
            Console.WriteLine($"PathsCount Memoized {DynamicProgramming.PathsCountMemoized(grid, 0, 0)}");
            Console.WriteLine($"PathsCount DynamicProg {DynamicProgramming.PathsCountDynamicProg(grid, 0, 0)}");
        }
    }
}
