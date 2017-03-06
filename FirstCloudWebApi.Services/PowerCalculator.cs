using System;
using System.CodeDom;

namespace FirstCloudWebApi.Services
{
    public class PowerCalculator
    {
        public int PowerIteractiverly(int baseNumber, int exp)
        {
            if (exp < 0)
            {
                throw new ArgumentException(nameof(exp));
            }

            var result = 1;
            for (var i = 1; i <= exp; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        public int PowerRecursively(int baseNumber, int exp)
        {
            if (exp < 0)
            {
                throw new ArgumentException(nameof(exp));
            }

            if (exp == 0)
            {
                return 1;
            }

            return baseNumber*this.PowerRecursively(baseNumber, exp - 1);
        }

        public int PowerRecursivelyWithImprovement(int baseNumber, int exp)
        {
            if (exp < 0)
            {
                throw new ArgumentException(nameof(exp));
            }

            if (exp == 0)
            {
                return 1;
            }
            else
            {
                var half = this.PowerRecursivelyWithImprovement(baseNumber, exp/2);
                if (exp%2 == 0)
                {
                    return half*half;
                }
                else
                {
                    return baseNumber*half*half;
                }
            }

            return 0;
        }
    }
}
