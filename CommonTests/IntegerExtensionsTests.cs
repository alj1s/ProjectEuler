
using NUnit.Framework;

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
    }
}
