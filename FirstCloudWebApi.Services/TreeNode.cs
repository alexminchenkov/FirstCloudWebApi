using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public void InOrderTraverse(List<int> traverseTracker)
        {
            this.Left?.InOrderTraverse(traverseTracker);
            this.Visit(traverseTracker);
            this.Right?.InOrderTraverse(traverseTracker);
        }

        public void PreOrderTraverse(List<int> traverseTracker)
        {
            this.Visit(traverseTracker);
            this.Left?.InOrderTraverse(traverseTracker);
            this.Right?.InOrderTraverse(traverseTracker);
        }

        public void PostOrderTraverse(List<int> traverseTracker)
        {
            this.Left?.InOrderTraverse(traverseTracker);
            this.Right?.InOrderTraverse(traverseTracker);
            this.Visit(traverseTracker);
        }

        public void Visit(List<int> traverseTracker)
        {
            traverseTracker.Add(this.Value);
        }

        public void Insert(TreeNode nodeToInsert)
        {
            if (nodeToInsert.Value < this.Value)
            {
                if (this.Left == null)
                {
                    this.Left = nodeToInsert;
                }
                else
                {
                    this.Left.Insert(nodeToInsert);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = nodeToInsert;
                }
                else
                {
                    this.Right.Insert(nodeToInsert);
                }
            }
        }

        public bool Contains(int checkingValue)
        {
            if (this.Value == checkingValue)
            {
                return true;
            }
            else if (checkingValue <= this.Left?.Value)
            {
                return this.Left?.Contains(checkingValue) ?? false;
            }
            else
            {
                return this.Right?.Contains(checkingValue) ?? false;
            }
        }
    }
}