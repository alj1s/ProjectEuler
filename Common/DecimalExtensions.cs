namespace Common
{
    public static class DecimalExtensions
    {
        public static bool IsInteger(this decimal d)
        {
            return d % 1 == 0;
        }
    }
}
