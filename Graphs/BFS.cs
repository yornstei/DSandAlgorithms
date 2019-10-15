using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    static class BFS
    {
        public static void PrintBFS(Graph graph, int start)
        {
            Queue<Node> nodes = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();

            nodes.Enqueue(graph.nodes[start]);
            visited.Add(start);

            while (nodes.TryDequeue(out Node curNode))
            {
                Console.WriteLine(curNode.id);

                foreach (var child in curNode.edges)
                    if (!visited.Contains(child.id))
                    {
                        //Console.WriteLine("|");
                        nodes.Enqueue(child);
                        visited.Add(child.id);
                    }
            }
        }

        public static bool ContainsBFS(Graph graph, int start, int value)
        {
            if (start == value) return true;

            Queue<Node> nodeQueue = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();

            nodeQueue.Enqueue(graph.nodes[start]);
            visited.Add(start);

            while (nodeQueue.TryDequeue(out Node curNode))
            {
                if (curNode.id == value)
                    return true;

                foreach (var child in curNode.edges)
                    if (!visited.Contains(child.id))
                    {
                        nodeQueue.Enqueue(child);
                        visited.Add(child.id);
                    }
            }

            return false;
        }
    }
}
