using System.Collections.Generic;
using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class InsertionSortTests
    {
        private readonly InsertionSort classUnderTest = new InsertionSort();

        [Fact]
        public void Sort_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            this.classUnderTest.Sort(source);

            // Assert
            Assert.Equal(expected, source);
        }

        [Fact]
        public void SortGeneric_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            this.classUnderTest.SortGeneric(source);

            // Assert
            Assert.Equal(expected, source);
        }

        [Fact]
        public void SortDesc_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { 20, 16, 12, 3, 2, 1, 0, -3 };

            // Action
            this.classUnderTest.SortDesc(source);

            // Assert
            Assert.Equal(expected, source);
        }
    }
}
