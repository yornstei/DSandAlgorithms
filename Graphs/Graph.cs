using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Graph
    {
        public Dictionary<int, Node> nodes;
        public Graph()
        {
            nodes = new Dictionary<int, Node>();
        }

        public Graph(int numOfNodes)
        {
            nodes = new Dictionary<int, Node>();
            for (int i = 0; i < numOfNodes; i++)
                nodes.Add(i, new Node(i));
        }

        public Graph(object[] objects)
        {
            nodes = new Dictionary<int, Node>();
            for (int i = 0; i < objects.Length; i++)
                nodes.Add(i, new Node(i, objects[i]));
        }

        public void AddDoubleEdge(int edgeOne, int edgeTwo)
        {
            Node o = nodes[edgeOne], t = nodes[edgeTwo];
            o.edges.Add(t);
            t.edges.Add(o);
        }

        public void AddSingleEdge(int source, int destination)
        {
            Node s = nodes[source], d = nodes[destination];
            s.edges.Add(d);
        }
    }
}
