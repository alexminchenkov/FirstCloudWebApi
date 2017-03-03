using System;
using System.Linq;

namespace FirstCloudWebApi.Services
{
    public class StringPermutationService
    {
        public bool IsPermutation(string source, string checking)
        {
            var sortedSource = new String(source.OrderBy(c => c).ToArray());
            var sortedChecking = new String(checking.OrderBy(c => c).ToArray());

            var result = sortedSource.Contains(sortedChecking);
            return result;
        }
    }
}