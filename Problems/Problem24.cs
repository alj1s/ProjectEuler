
using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problems
{
    public class Problem24 : IProblem
    {
        public string Solve()
        {
            return SolveForLength(10, 1000000);
        }

        public static string SolveForLength(int length, int permutation)
        {
            var array = new List<int>(Enumerable.Range(0,length));
            var result = string.Empty;

            for (int i = length - 1; i >= 0 && permutation > 0; i--)
            {
                var factorial = i.Factorial();
                var index = permutation/factorial;

                if (permutation == factorial)
                {
                    result += string.Join(string.Empty, array);
                    break;
                }

                if (permutation%factorial == 0)
                    index--;

                result += array[index];
                permutation -= index * i.Factorial();
                array.RemoveAt(index);
            }

            return result;
        }
    }
}
