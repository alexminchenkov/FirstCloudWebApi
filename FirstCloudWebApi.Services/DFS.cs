using System.Collections.Generic;
using System.Linq;

namespace FirstCloudWebApi.Services
{
    public class DFS
    {
        private List<Node> visitedNodes;

        public string Traverse(Graph graph)
        {
            this.visitedNodes = new List<Node>();

            var rootNode = graph.Nodes[0];

            this.Traverse(rootNode);

            var result = string.Join("->", this.visitedNodes.Select(n => n.Name));
            return result;
        }

        private void Traverse(Node rootNode)
        {
            if (this.visitedNodes.Contains(rootNode))
            {
                return;
            }

            this.Visit(rootNode);

            foreach (var neighbour in rootNode.Neighbors)
            {
                this.Traverse(neighbour);
            }
        }

        private void Visit(Node node)
        {
            this.visitedNodes.Add(node);
        }

        public bool HasPath(Graph graph, string source, string dest)
        {
            this.visitedNodes = new List<Node>();

            var sourceNode = graph.GetNodeByName(source);
            var destNode = graph.GetNodeByName(dest);

            var result = this.HasPath(sourceNode, destNode);
            return result;
        }

        private bool HasPath(Node sourceNode, Node destNode)
        {
            if (sourceNode.Equals(destNode))
            {
                return true;
            }

            if (this.visitedNodes.Contains(sourceNode))
            {
                return false;
            }

            this.visitedNodes.Add(sourceNode);

            foreach (var sourceNeighbour in sourceNode.Neighbors)
            {
                if (this.HasPath(sourceNeighbour, destNode))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
