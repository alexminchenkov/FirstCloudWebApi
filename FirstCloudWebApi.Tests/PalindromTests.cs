using FirstCloudWebApi.Services;
using Xunit;

namespace FirstCloudWebApi.Tests
{
    public class PalindromTests
    {
        private readonly Palindrom classUnderTest = new Palindrom();

        [Theory]
        [InlineData("a", true)]
        [InlineData("aba", true)]
        [InlineData("was it a car or a cat I saw", true)]
        [InlineData("was it a car or a cat I sOw", false)]
        [InlineData("go hang a salami im a lasagna hog", true)]
        [InlineData("Ho hang a salami im a lasagna hog", false)]
        public void CheckInteractiverly_ShouldWorkCorrectly(string checking, bool expected)
        {
            // Action
            var actual = this.classUnderTest.CheckInteractiverly(checking);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", true)]
        [InlineData("aba", true)]
        [InlineData("was it a car or a cat I saw", true)]
        [InlineData("was it a car or a cat I sOw", false)]
        [InlineData("go hang a salami im a lasagna hog", true)]
        [InlineData("Ho hang a salami im a lasagna hog", false)]
        public void CheckRecursively_ShouldWorkCorrectly(string checking, bool expected)
        {
            // Action
            var actual = this.classUnderTest.CheckRecursively(checking);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
