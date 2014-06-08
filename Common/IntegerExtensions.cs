
using System;

namespace Common
{
    public static class IntegerExtensions
    {
        public static bool IsPrime(this int n)
        {
            return Prime.IsPrime(n);
        }

        public static int Factorial(this int n)
        {
            if (n == 1 || n == 0) return 1;
            return n * (n - 1).Factorial();
        }

        public static int GetNthDigit(this int number, int n)
        {
            var result = (number % Math.Pow(10, n)) / Math.Pow(10, n - 1);
            return (int)result;
        }

        public static int Gcd(this int n, int m)
        {
            int remainder;

            while (n != 0)
            {
                remainder = m % n;
                m = n;
                n = remainder;
            }

            return m;
        }
    }
}
