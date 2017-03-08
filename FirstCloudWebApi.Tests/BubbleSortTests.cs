using System.Collections.Generic;
using FirstCloudWebApi.Services;
using NUnit.Framework;

namespace FirstCloudWebApi.Tests
{
    public class BubbleSortTests
    {
        private readonly BubbleSort classUnderTest = new BubbleSort();

        [Test]
        public void Sort_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            var result = this.classUnderTest.Sort(source);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void SortWithImprovement_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            this.classUnderTest.SortWithImprovement(source);

            // Assert
            CollectionAssert.AreEqual(expected, source);
        }

        [Test]
        public void SortGeneric_ShouldReturnCorrectResult()
        {
            // Arrange
            var source = new List<int> { 2, 3, 1, 16, -3, 0, 12, 20 };
            var expected = new List<int> { -3, 0, 1, 2, 3, 12, 16, 20 };

            // Action
            this.classUnderTest.SortGeneric(source);

            // Assert
            CollectionAssert.AreEqual(expected, source);
        }
    }
}
