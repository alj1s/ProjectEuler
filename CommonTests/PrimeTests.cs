
using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture()]
    public class PrimeTests
    {
        [TestCase(2,true)]
        [TestCase(12, false)]
        [TestCase(1, false)]
        [TestCase(3, true)]
        [TestCase(41, true)]
        public void IsPrimeTest(int number, bool expected)
        {
            Assert.AreEqual(expected, number.IsPrime());
        }
    }
}
