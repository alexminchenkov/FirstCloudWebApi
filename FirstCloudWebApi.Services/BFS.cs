using System.Collections.Generic;
using System.Linq;

namespace FirstCloudWebApi.Services
{
    public class BFS
    {
        private List<Node> visitedNodes;
        private Queue<Node> nextToVisitNodes;

        public string Traverse(Graph graph)
        {
            this.nextToVisitNodes = new Queue<Node>();
            this.visitedNodes = new List<Node>();

            var startNode = graph.Nodes[0];
            this.Traverse(startNode);

            var traverseResult = string.Join("->", visitedNodes.Select(n => n.Name));
            return traverseResult;
        }

        private void Traverse(Node rootNode)
        {
            this.nextToVisitNodes.Enqueue(rootNode);

            while (this.nextToVisitNodes.Count > 0)
            {
                var currentNode = this.nextToVisitNodes.Dequeue();

                if (this.visitedNodes.Contains(currentNode))
                {
                    continue;
                }

                this.Visit(currentNode);

                foreach (var neighbour in currentNode.Neighbors)
                {
                    this.nextToVisitNodes.Enqueue(neighbour);
                }
            }
        }

        private void Visit(Node node)
        {
            this.visitedNodes.Add(node);
        }

        public bool HasPath(Graph graph, string source, string dest)
        {
            this.nextToVisitNodes = new Queue<Node>();
            this.visitedNodes = new List<Node>();

            var sourceNode = graph.GetNodeByName(source);
            var destNode = graph.GetNodeByName(dest);

            this.nextToVisitNodes.Enqueue(sourceNode);

            while (this.nextToVisitNodes.Count > 0)
            {
                var currentNode = this.nextToVisitNodes.Dequeue();

                if (this.visitedNodes.Contains(currentNode))
                {
                    continue;
                }

                if (currentNode.Equals(destNode))
                {
                    return true;
                }

                this.visitedNodes.Add(currentNode);

                foreach (var currentNodeNeighbour in currentNode.Neighbors)
                {
                    this.nextToVisitNodes.Enqueue(currentNodeNeighbour);
                }
            }

            return false;
        }
    }
}
