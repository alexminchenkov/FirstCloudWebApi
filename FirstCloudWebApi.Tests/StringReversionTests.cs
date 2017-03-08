using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class StringReversionTests
    {
        private readonly StringReversion classUnderTest = new StringReversion();

        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abc", "cba")]
        public void RunIteractively_ShouldReturnCorrectResult(string source, string expected)
        {
            // Action
            var actual = this.classUnderTest.RunIteractively(source);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abc", "cba")]
        [InlineData("abcde", "edcba")]
        public void RunRecursively_ShouldReturnCorrectResult(string source, string expected)
        {
            // Action
            var actual = this.classUnderTest.RunRecursively(source);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abc", "cba")]
        [InlineData("abcde", "edcba")]
        public void RunIteractivelyByBuildingNewString_ShouldReturnCorrectResult(string source, string expected)
        {
            // Action
            var actual = this.classUnderTest.RunIteractivelyByBuildingNewString(source);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
