using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class TowersOfHanoiTests
    {
        private readonly TowersOfHanoi classUnderTest = new TowersOfHanoi();

        [Fact]
        public void MoveDisks_ShouldReturnCorrectActions()
        {
            // Arrange
            var disksCount = 3;

            // Action
            var result = this.classUnderTest.MoveDisks(disksCount);

            // Assert
            var expected = "(1-3), (1-2), (3-2), (1-3), (2-1), (2-3), (1-3)";
            Assert.Equal(expected, result);
        }
    }
}
