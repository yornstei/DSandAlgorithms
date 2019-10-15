using System;
using System.Diagnostics;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();

            Graph graph = new Graph(10);

            graph.AddDoubleEdge(0, 1);
            graph.AddDoubleEdge(2, 1);
            graph.AddDoubleEdge(3, 1);
            graph.AddDoubleEdge(0, 4);
            graph.AddDoubleEdge(3, 2);
            graph.AddDoubleEdge(3, 6);
            graph.AddDoubleEdge(3, 5);
            graph.AddDoubleEdge(4, 7);
            graph.AddDoubleEdge(5, 8);
            graph.AddDoubleEdge(5, 9);

            BFS.PrintBFS(graph, 1);
            stopwatch.Start();
            Console.WriteLine(BFS.ContainsBFS(graph, 1, 6));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(BFS.ContainsBFS(graph, 1, 10));

            DFS.PrintDFS(graph.nodes[1]);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(DFS.ContainsDFS(graph.nodes[1], 6));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(DFS.ContainsDFS(graph.nodes[1], 10));

            Console.ReadKey();
        }
    }
}
