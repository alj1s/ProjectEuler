
using System;

namespace Common
{
    public class Prime
    {
        public static bool 
            IsPrime(int number)
        {
            if (number <= 1) return false;

            var root = (int) Math.Sqrt(number);
            for (int i = 2; i < root; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
