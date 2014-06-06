using System;
using Common;

namespace Problems
{
    public class Problem25 : IProblem
    {
        public string Solve()
        {
            int i = 0;
            while (FibonacciGenerator.Generate(i).ToString().Length < 1000)
            {
                i++;
                if(i == int.MaxValue)
                    throw new Exception("Index is too large to calculate");
            }

            return i.ToString();
        }
    }
}
