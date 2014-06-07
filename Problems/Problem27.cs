using System;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem27 : IProblem
    {
        public string Solve()
        {
            var coefficientRange = Enumerable.Range(-999, 1999).ToList();

            var pair = from p in coefficientRange
                       from q in coefficientRange
                       select Tuple.Create(p, q);

            var coefficients = pair.OrderByDescending(ConsecutivePrimeLength).First();

            var product = coefficients.Item1 * coefficients.Item2;
            return product.ToString();
        }

        private int CalculateExpression(int n, Tuple<int, int> coefficients)
        {
            return (n * n) + (coefficients.Item1 * n) + coefficients.Item2;
        }

        public int ConsecutivePrimeLength(Tuple<int, int> coefficients)
        {
            var length = 0;
           

            while (CalculateExpression(length, coefficients).IsPrime())
            {
                length++;
            }

            return length;
        }
    }
}
