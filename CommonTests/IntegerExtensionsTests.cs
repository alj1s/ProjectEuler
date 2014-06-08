
using NUnit.Framework;
using Common;

namespace Common.Tests
{
    [TestFixture()]
    public class IntegerExtensionsTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void FactorialTest(int number, int expected)
        {
            Assert.AreEqual(expected, number.Factorial());
        }

        [TestCase(2,4,2)]
        public void GcdTest(int first, int second, int gcd)
        {
            Assert.AreEqual(gcd, first.Gcd(second));
        }
    }
}
