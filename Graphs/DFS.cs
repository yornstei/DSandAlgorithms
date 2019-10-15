using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    static class DFS
    {
        public static void PrintDFS(Node start, HashSet<int> visitedNodes = null)
        {
            HashSet<int> visited = visitedNodes ?? new HashSet<int>();

            if (visited.Contains(start.id)) return;

            Console.WriteLine(start.id);
            visited.Add(start.id);

            foreach (var child in start.edges)
                PrintDFS(child, visited);
        }

        public static bool ContainsDFS(Node start, int value, HashSet<int> visitedNodes = null)
        {
            if (start.id == value) return true;

            HashSet<int> visited = visitedNodes ?? new HashSet<int>();

            if (visited.Contains(start.id)) return false;

            visited.Add(start.id);

            foreach (var child in start.edges)
                if (ContainsDFS(child, value, visited))
                    return true;

            return false;
        }
    }
}
