using System.Collections.ObjectModel;
using System.Numerics;

namespace Common
{
    public class FibonacciGenerator
    {
        static FibonacciGenerator()
        {
            Cache.Insert(0, new BigInteger(0));
            Cache.Insert(1, new BigInteger(1));
            Cache.Insert(2, new BigInteger(1));

        }

        private static readonly Collection<BigInteger> Cache = new Collection<BigInteger>();

        public static BigInteger Generate(int index)
        {
            if (Cache.Count > index)
                return Cache[index];

            var answer = Generate(index - 1) + Generate(index - 2);
            Cache.Insert(index, answer);
            return answer;

        }
    }
}