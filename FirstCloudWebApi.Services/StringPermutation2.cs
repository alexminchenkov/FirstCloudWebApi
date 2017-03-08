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
                    var newSoFar = soFar + rest[i];
                    var newRest = rest.Substring(0, i) + rest.Substring(i + 1); // rest string except rest[i]
                    this.ComputePermutations(newSoFar, newRest);
                }
            }
        }

        public string GetPermutationsWithSubsets(string source)
        {
            this.permutations = new List<string>();

            this.ComputePermutationsWithSubsets("", source);

            var result = string.Join(", ", this.permutations);
            return result;
        }

        private void ComputePermutationsWithSubsets(string soFar, string rest)
        {
            if (string.IsNullOrEmpty(rest))
            {
                this.permutations.Add(soFar);
            }
            else
            {
                var newSoFar = soFar + rest[0];
                var newRest = rest.Substring(1);

                ComputePermutationsWithSubsets(newSoFar, newRest);

                ComputePermutationsWithSubsets(soFar, newRest);

                //ComputePermutationsWithSubsets(soFar + rest[0], rest.Substring(1));

                //ComputePermutationsWithSubsets(soFar, rest.Substring(1));
            }
        }
    }
}
