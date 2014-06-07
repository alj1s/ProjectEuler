using System.Linq;
using System.Numerics;

namespace Problems
{
    public class Problem26 : IProblem
    {
        public string Solve()
        {
            var ordered = Enumerable.Range(1, 1000).AsParallel().OrderByDescending(CycleLength);
            return ordered.First().ToString();
        }

        public static int CycleLength(int n)
        {
            for (int j = 1; ; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    var ten = new BigInteger(10);
                    var nBigInteger = new BigInteger(n);
                    if ((BigInteger.Pow(ten, j) - BigInteger.Pow(ten, i)) % nBigInteger == 0)
                        return j - i;            
  
                }
            }
        }
    }
}
