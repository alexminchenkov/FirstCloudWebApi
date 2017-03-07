using System.Collections.Generic;
using System.Linq;

namespace FirstCloudWebApi.Services
{
    public class BinarySearch
    {
        public bool Search(List<int> source, int searchingValue)
        {
            if (source.Count == 0)
            {
                return false;
            }

            if (source.Count == 1 && source[0] != searchingValue)
            {
                return false;
            }

            int half = source.Count/2;
            if (source[half] == searchingValue)
            {
                return true;
            }

            if (source[half] >= searchingValue)
            {
                return this.Search(source.Take(half).ToList(), searchingValue);
            }

            return this.Search(source.Skip(half).ToList(), searchingValue);
        }

        public bool SearchWithIndexes(List<int> source, int searchingValue)
        {
            return this.Search(source, searchingValue, 0, source.Count - 1);
        }

        private bool Search(List<int> source, int searchingValue, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return false;
            }

            var mediumIndex = (endIndex + startIndex)/2;
            if (source[mediumIndex] == searchingValue)
            {
                return true;
            }

            if (source[mediumIndex] <= searchingValue)
            {
                return this.Search(source, searchingValue, mediumIndex + 1, endIndex);
            }

            return this.Search(source, searchingValue, 0, mediumIndex - 1);
        }
    }
}