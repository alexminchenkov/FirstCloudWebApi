using FirstCloudWebApi.Services;
using System.Collections.Generic;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class QuickSortTests
    {
        private readonly QuickSort classUnderTest = new QuickSort();

        [Fact]
        public void SortGeneric_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            this.classUnderTest.Sort(source);

            // Assert
            Assert.Equal(expected, source);
        }
    }
}
