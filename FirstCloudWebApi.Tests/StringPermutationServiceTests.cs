using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class StringPermutationServiceTests
    {
        private readonly StringPermutationService classUnderTest = new StringPermutationService();

        [Theory]
        [InlineData("edabc", "de", true)]
        [InlineData("edabc", "ed", true)]
        [InlineData("edabc", "ac", false)]
        [InlineData("edabc", "ade", false)]
        [InlineData("edacb", "abc", true)]
        public void IsPermutation_ShouldWorkCorrectly(string source, string checking, bool expected)
        {
            // Action
            var actual = this.classUnderTest.IsPermutation(source, checking);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
