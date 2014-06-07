using System.Numerics;
using NUnit.Framework;
namespace Common.Tests
{
    [TestFixture()]
    public class FibonacciGeneratorTests
    {
        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void FibonacciGeneratorTest(int index, int expected)
        {
            Assert.AreEqual(new BigInteger(expected), FibonacciGenerator.Generate(index));
        }


    }
}
