using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class Anagram
    {
        private readonly List<string> wordsDict = new List<string>();

        public Anagram()
        {
            this.InitWordsDict();
        }

        public bool IsAnagram(string source)
        {
            var result = this.IsAnagram(string.Empty, source);
            return result;
        }

        private bool IsAnagram(string prefix, string rest)
        {
            if (string.IsNullOrEmpty(rest))
            {
                return this.wordsDict.Contains(prefix);
            }
            else
            {
                for (int i = 0; i < rest.Length; i++)
                {
                    var newPrefix = prefix + rest[i];
                    var newRest = rest.Substring(0, i) + rest.Substring(i + 1); // exclude rest[i]

                    bool isAnagram = this.IsAnagram(newPrefix, newRest);
                    if (isAnagram)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void InitWordsDict()
        {
            wordsDict.Add("abbott");
            wordsDict.Add("cat");
        }
    }
}