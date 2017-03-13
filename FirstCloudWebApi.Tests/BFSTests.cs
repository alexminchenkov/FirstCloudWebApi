using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class BFSTests
    {
        private readonly BFS classUnderTest = new BFS();

        [Fact]
        public void Traverse_ShouldReturnCorrectResult()
        {
            // Arrange
            var graph = Graph.Create();

            // Act
            var traverseOutput = this.classUnderTest.Traverse(graph);

            // Assert
            var expected = "0->1->4->5->3->2";
            Assert.Equal(expected, traverseOutput);
        }

        [Theory]
        [InlineData("0", "1", true)]
        [InlineData("0", "2", true)]
        [InlineData("1", "3", true)]
        [InlineData("3", "1", true)]
        [InlineData("2", "3", true)]
        [InlineData("4", "5", false)]
        [InlineData("4", "3", false)]
        [InlineData("1", "0", false)]
        public void HasPath_ShouldReturnCorrectResult(string source, string dest, bool expected)
        {
            // Arrange
            var graph = Graph.Create();

            // Act
            var actual = this.classUnderTest.HasPath(graph, source, dest);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
