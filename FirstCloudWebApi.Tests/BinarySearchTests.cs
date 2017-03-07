using System.Collections.Generic;
using FirstCloudWebApi.Services;
using NUnit.Framework;

namespace FirstCloudWebApi.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        private readonly BinarySearch classUnderTest = new BinarySearch();

        [Test]
        public void Search_GivenSearchingItemInFirstHalfOfSource_ShouldReturnTrue()
        {
            // Arrange
            List<int> source = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int searchingValue = 2;

            // Action
            var result = this.classUnderTest.Search(source, searchingValue);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Search_GivenSearchingItemInSecondHalfOfSource_ShouldReturnTrue()
        {
            // Arrange
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchingValue = 8;

            // Action
            var result = this.classUnderTest.Search(source, searchingValue);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Search_GivenNoSearchingItemInSource_ShouldReturnFalse()
        {
            // Arrange
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchingValue = 18;

            // Action
            var result = this.classUnderTest.Search(source, searchingValue);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Search_GivenNoEmptySource_ShouldReturnFalse()
        {
            // Arrange
            List<int> source = new List<int>();
            int searchingValue = 18;

            // Action
            var result = this.classUnderTest.Search(source, searchingValue);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void SearchWithIndexes_GivenSearchingItemInFirstHalfOfSource_ShouldReturnTrue()
        {
            // Arrange
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchingValue = 2;

            // Action
            var result = this.classUnderTest.SearchWithIndexes(source, searchingValue);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void SearchWithIndexes_GivenSearchingItemInSecondHalfOfSource_ShouldReturnTrue()
        {
            // Arrange
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchingValue = 9;

            // Action
            var result = this.classUnderTest.SearchWithIndexes(source, searchingValue);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void SearchWithIndexes_GivenNoSearchingItemInSource_ShouldReturnFalse()
        {
            // Arrange
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchingValue = 18;

            // Action
            var result = this.classUnderTest.SearchWithIndexes(source, searchingValue);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void SearchWithIndexes_GivenNoEmptySource_ShouldReturnFalse()
        {
            // Arrange
            List<int> source = new List<int>();
            int searchingValue = 18;

            // Action
            var result = this.classUnderTest.SearchWithIndexes(source, searchingValue);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
