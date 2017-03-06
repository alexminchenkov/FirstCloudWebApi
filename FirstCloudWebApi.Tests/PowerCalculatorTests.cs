using System;
using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class PowerCalculatorTests
    {
        private readonly PowerCalculator classUnderTest = new PowerCalculator();

        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 3, 27)]
        [InlineData(2, 6, 64)]
        public void PowerIteractiverly_ShouldReturnCorrectResult(int baseNumber, int exp, int expected)
        {
            // Action
            var actual = this.classUnderTest.PowerIteractiverly(baseNumber, exp);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerIteractiverly_GivenNegativeNumber_ShouldThrowArgumentException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var actual = this.classUnderTest.PowerIteractiverly(2, -1);
            });
        }

        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 3, 27)]
        [InlineData(2, 6, 64)]
        public void PowerRecursively_ShouldReturnCorrectResult(int baseNumber, int exp, int expected)
        {
            // Action
            var actual = this.classUnderTest.PowerRecursively(baseNumber, exp);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerRecursively_GivenNegativeNumber_ShouldThrowArgumentException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var actual = this.classUnderTest.PowerRecursively(2, -1);
            });
        }

        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 3, 27)]
        [InlineData(2, 6, 64)]
        [InlineData(2, 5, 32)]
        public void PowerRecursivelyWithImprovement_ShouldReturnCorrectResult(int baseNumber, int exp, int expected)
        {
            // Action
            var actual = this.classUnderTest.PowerRecursivelyWithImprovement(baseNumber, exp);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerRecursivelyWithImprovement_GivenNegativeNumber_ShouldThrowArgumentException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                var actual = this.classUnderTest.PowerRecursivelyWithImprovement(2, -1);
            });
        }
    }
}
