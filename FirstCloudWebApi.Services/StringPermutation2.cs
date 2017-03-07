using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class StringPermutation2
    {
        private List<string> permutations;

        public string GetPermutations(string source)
        {
            this.permutations = new List<string>();

            this.ComputePermutations("", source);

            var result = string.Join(", ", this.permutations);
            return result;
        }

        private void ComputePermutations(string soFar, string rest)
        {
            if (string.IsNullOrEmpty(rest))
            {
                this.permutations.Add(soFar);
            }
            else
            {
                for (int i = 0; i < rest.Length; i++)
                {
                    var newSoFar = soFar + rest.Substring(i, 1); // string[i]
                    var newRest = rest.Substring(0, i) + rest.Substring(i + 1); // rest string except string[i]
                    this.ComputePermutations(newSoFar, newRest);

                }

                //var newSoFar = rest.Substring(0, 1);
                //var newRest = rest.Substring(1, 0);

                //this.ComputePermutations(newSoFar, newRest);
            }
        }
    }
}
