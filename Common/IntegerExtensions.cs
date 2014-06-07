
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
            return n * (n-1).Factorial();
        }
    }
}
