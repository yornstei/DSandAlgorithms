using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Node
    {
        public int id { get; set; }
        public object data { get; set; }
        public List<Node> edges { get; set; }
        public Node(int id, object data = null)
        {
            this.id = id;
            this.data = data;
            edges = new List<Node>();
        }
    }
}
