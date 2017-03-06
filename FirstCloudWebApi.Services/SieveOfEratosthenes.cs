using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstCloudWebApi.Services
{
    public class SieveOfEratosthenes
    {
        private Dictionary<int, bool> allNumbersUptoMax;

        public List<int> ComputeFor(int maxValue)
        {
            this.InitAllNumbers(maxValue);

            var prime = 2;
            while (prime <= Math.Sqrt(maxValue))
            {
                this.CrossOffNumbersForPrime(prime);
                prime = this.GetNextPrime(prime);
            }

            var result = this.allNumbersUptoMax.Where(n => n.Value == true).Select(n => n.Key).ToList();
            return result;
        }

        private void InitAllNumbers(int maxValue)
        {
            this.allNumbersUptoMax = new Dictionary<int, bool>(maxValue + 1);
            for (var i = 0; i <= maxValue; i++)
            {
                this.allNumbersUptoMax[i] = true;
            }

            this.allNumbersUptoMax[0] = false;
            this.allNumbersUptoMax[1] = false;
        }

        private void CrossOffNumbersForPrime(int prime)
        {
            for (int i = prime * prime; i < this.allNumbersUptoMax.Count; i += prime)
            {
                this.allNumbersUptoMax[i] = false;
            }
        }

        private int GetNextPrime(int currentPrime)
        {
            return this.allNumbersUptoMax.FirstOrDefault(n => n.Key > currentPrime && n.Value == true).Key;
        }
    }
}