using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class Graph
    {
        public Graph()
        {
            this.Nodes = new List<Node>();
        }

        public List<Node> Nodes { get; private set; }

        public Node GetNodeByName(string name)
        {
            return this.Nodes.Find(n => n.Name == name);
        }

        public void AddNode(Node node)
        {
            this.Nodes.Add(node);
        }

        public static Graph Create()
        {
            var graph = new Graph();

            var node0 = new Node("0");
            var node1 = new Node("1");
            var node2 = new Node("2");
            var node3 = new Node("3");
            var node4 = new Node("4");
            var node5 = new Node("5");

            node0.Neighbors.Add(node1);
            node0.Neighbors.Add(node4);
            node0.Neighbors.Add(node5);

            node1.Neighbors.Add(node3);
            node1.Neighbors.Add(node4);

            node2.Neighbors.Add(node1);

            node3.Neighbors.Add(node2);
            node3.Neighbors.Add(node4);

            graph.AddNode(node0);
            graph.AddNode(node1);
            graph.AddNode(node2);
            graph.AddNode(node3);
            graph.AddNode(node4);

            return graph;
        }
    }
}
