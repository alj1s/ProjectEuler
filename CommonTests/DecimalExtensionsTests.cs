using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture]
    public class DecimalExtensionsTests
    {
        [TestCase(3.0, true)]
        [TestCase(1.0, true)]
        [TestCase(-1.0, true)]
        [TestCase(0.0, true)]
        [TestCase(3.0000001, false)]
        [TestCase(3.00000000000001, false)]
        public void IsIntegerTest(decimal number, bool expected)
        {
            Assert.AreEqual(expected, number.IsInteger());
        }
    }
}
