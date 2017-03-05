using System.Collections.Generic;
using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class SieveOfEratosthenesTests
    {
        private readonly SieveOfEratosthenes classUnderTest = new SieveOfEratosthenes();

        [Fact]
        public void ComputeFor_ShouldReturnCorrectResult()
        {
            // Arrange
            var maxValue = 20;

            // Action
            var result = this.classUnderTest.ComputeFor(maxValue);

            // Assert
            var expected = new List<int> {2, 3, 5, 7, 11, 13, 17, 19};
            Assert.Equal(expected, result);
        }
    }
}
