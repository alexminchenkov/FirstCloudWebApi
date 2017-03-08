using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class AnagramTests
    {
        private readonly Anagram classUnderTest = new Anagram();

        [Theory]
        [InlineData("tobtab", true)]
        [InlineData("tac", true)]
        [InlineData("taz", false)]
        public void IsAnagram_ShouldReturnCorrectResult(string source, bool expected)
        {
            // Action
            var actual = this.classUnderTest.IsAnagram(source);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
