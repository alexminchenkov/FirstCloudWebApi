using System.Collections.Generic;
using FirstCloudWebApi.Services;
using NUnit.Framework;

namespace FirstCloudWebApi.Tests
{
    [TestFixture]
    public class BinarySearchTreeTests
    {
        [TestCaseSource(nameof(GetInOrderTraverseTestCases))]
        public void TraverseInOrder_ShouldReturnCorrectOutput(TraverseTreeTestCase testCase)
        {
            // Act
            var result = testCase.Tree.InOrderTraverse();

            // Assert
            Assert.AreEqual(testCase.ExpectedTraverseOutput, result);
        }

        [TestCaseSource(nameof(GetPreOrderTraverseTestCases))]
        public void TraversePreOrder_ShouldReturnCorrectOutput(TraverseTreeTestCase testCase)
        {
            // Act
            var result = testCase.Tree.PreOrderTraverse();

            // Assert
            Assert.AreEqual(testCase.ExpectedTraverseOutput, result);
        }

        [TestCaseSource(nameof(GetPostOrderTraverseTestCases))]
        public void TraversePostOrder_ShouldReturnCorrectOutput(TraverseTreeTestCase testCase)
        {
            // Act
            var result = testCase.Tree.PostOrderTraverse();

            // Assert
            Assert.AreEqual(testCase.ExpectedTraverseOutput, result);
        }

        [Test]
        public void InsertWorksAsExpected()
        {
            // Arrange
            var tree = BuildSimpleTree();
            var nodeToInsert = new TreeNode(8);

            // Act
            tree.Insert(nodeToInsert);

            // Assert
            var actualTraverse = tree.InOrderTraverse();
            var expectedTraverse = "5->8->10->15";
            Assert.AreEqual(expectedTraverse, actualTraverse);
        }

        [TestCase(1, true)]
        [TestCase(10, true)]
        [TestCase(30, true)]
        [TestCase(0, false)]
        [TestCase(12, false)]
        [TestCase(50, false)]
        public void Contains_ShouldReturnCorrectResult(int checkingValue, bool expected)
        {
            // "1->3->4->5->9->10->13->15->17->20->25->30" 
            // Arrange
            var tree = BuildComplexTree();

            // Act
            var result = tree.Contains(checkingValue);

            // Assert
            Assert.AreEqual(expected, result);
        }

        #region Helper Methods

        private static BinarySearchTree BuildSimpleTree()
        {
            var result = new BinarySearchTree
            {
                Root = new TreeNode(10)
                {
                    Left = new TreeNode(5),
                    Right = new TreeNode(15)
                }
            };

            return result;
        }

        private static BinarySearchTree BuildComplexTree()
        {
            var result = new BinarySearchTree
            {
                Root = new TreeNode(10)
                {
                    Left = new TreeNode(5)
                    {
                        Left = new TreeNode(3)
                        {
                            Left = new TreeNode(1),
                            Right = new TreeNode(4)
                        },
                        Right = new TreeNode(9)
                    },
                    Right = new TreeNode(20)
                    {
                        Left = new TreeNode(15)
                        {
                            Left = new TreeNode(13),
                            Right = new TreeNode(17)
                        },
                        Right = new TreeNode(25)
                        {
                            Right = new TreeNode(30)
                        }
                    }
                }
            };

            return result;
        }

        private static IEnumerable<TraverseTreeTestCase> GetInOrderTraverseTestCases()
        {
            yield return new TraverseTreeTestCase { Tree = BuildSimpleTree(), ExpectedTraverseOutput = "5->10->15" };

            yield return new TraverseTreeTestCase { Tree = BuildComplexTree(), ExpectedTraverseOutput = "1->3->4->5->9->10->13->15->17->20->25->30" };
        }

        private static IEnumerable<TraverseTreeTestCase> GetPreOrderTraverseTestCases()
        {
            yield return new TraverseTreeTestCase { Tree = BuildSimpleTree(), ExpectedTraverseOutput = "10->5->15" };
        }

        private static IEnumerable<TraverseTreeTestCase> GetPostOrderTraverseTestCases()
        {
            yield return new TraverseTreeTestCase { Tree = BuildSimpleTree(), ExpectedTraverseOutput = "5->15->10" };
        }

        public class TraverseTreeTestCase
        {
            public BinarySearchTree Tree { get; set; }

            public string ExpectedTraverseOutput { get; set; }
        }

        #endregion Helper Methods
    }
}
