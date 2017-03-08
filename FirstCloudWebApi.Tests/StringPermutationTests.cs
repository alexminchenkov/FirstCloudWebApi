using FirstCloudWebApi.Services;
using NUnit.Framework;

namespace FirstCloudWebApi.Tests
{
    [TestFixture]
    public class StringPermutationTests
    {
        private readonly StringPermutation2 classUnderTest = new StringPermutation2();

        [TestCase("a", "a")]
        [TestCase("ab", "ab, ba")]
        [TestCase("abc", "abc, acb, bac, bca, cab, cba")]
        public void GetPermutations_ShouldReturnCorrectResult(string source, string expected)
        {
            // Action
            var result = this.classUnderTest.GetPermutations(source);

            // Assert
            Assert.AreEqual(expected, result);
        }

        //[TestCase("a", "a")]
        //[TestCase("ab", "ab, ba")]
        //[TestCase("abc", "abc, acb, bac, bca, cab, cba")]
        public void GetPermutationsWithSubsets_ShouldReturnCorrectResult(string source, string expected)
        {
            // Action
            var result = this.classUnderTest.GetPermutationsWithSubsets(source);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
