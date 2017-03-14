using System;
using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; }

        public string InOrderTraverse()
        {
            return this.Traverse(this.Root.InOrderTraverse);
        }

        public string PreOrderTraverse()
        {
            return this.Traverse(this.Root.PreOrderTraverse);
        }

        public string PostOrderTraverse()
        {
            return this.Traverse(this.Root.PostOrderTraverse);
        }

        private string Traverse(Action<List<int>> action)
        {
            var traverseTracker = new List<int>();
            action(traverseTracker);

            var result = this.BuildTraverseOutput(traverseTracker);
            return result;
        }

        private string BuildTraverseOutput(List<int> traverseTracker)
        {
            var result = string.Join("->", traverseTracker);
            return result;
        }

        public void Insert(TreeNode nodeToInsert)
        {
            this.Root.Insert(nodeToInsert);
        }

        public bool Contains(int checkingValue)
        {
            var result = this.Root.Contains(checkingValue);
            return result;
        }
    }
}
