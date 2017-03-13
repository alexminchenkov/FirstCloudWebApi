using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class Node
    {
        public Node()
        {
            this.Neighbors = new List<Node>();
        }

        public Node(string name)
        {
            this.Name = name;
            this.Neighbors = new List<Node>();
        }

        public string Name { get; }

        public List<Node> Neighbors { get; }

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            var otherNode = obj as Node;
            if (otherNode == null)
            {

                return false;
            }

            return this.Name == otherNode.Name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
