
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Problems
{
    public class Problem31 : IProblem
    {
        public string Solve()
        {
            var coins = new List<int> {200,100,50,20,10,5,2,1};
            var number = CountNumberOfWays(200, coins.Count - 1, coins );

            return number.ToString();
        }

        private int CountNumberOfWays(int amount, int index, List<int> coins)
        {
            if (amount == 0)
                return 1;

            if (amount < 0)
                return 0;

            if (index < 0 && amount >= 0)
                return 0;

            return CountNumberOfWays(amount, index - 1, coins) + CountNumberOfWays(amount - coins[index], index, coins);
        }
    }
}
