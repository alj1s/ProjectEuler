
using NUnit.Framework;
namespace Problems.Tests
{
    [TestFixture()]
    public class Problem24Tests
    {
        [TestCase(4, 1, "0123")]
        [TestCase(4, 2, "0132")]
        [TestCase(4, 3, "0213")]
        [TestCase(4, 4, "0231")]
        [TestCase(4, 5, "0312")]
        [TestCase(4, 6, "0321")]
        [TestCase(4, 7, "1023")]
        [TestCase(4, 8, "1032")]
        [TestCase(4, 9, "1203")]
        [TestCase(4, 10, "1230")]
        [TestCase(4, 11, "1302")]
        [TestCase(4, 12, "1320")]
        [TestCase(4, 13, "2013")]
        [TestCase(4, 14, "2031")]
        [TestCase(4, 15, "2103")]
        [TestCase(4, 16, "2130")]
        [TestCase(4, 17, "2301")]
        [TestCase(4, 18, "2310")]
        [TestCase(4, 19, "3012")]
        [TestCase(4, 20, "3021")]
        [TestCase(4, 21, "3102")]
        [TestCase(4, 22, "3120")]
        [TestCase(4, 23, "3201")]
        [TestCase(4, 24, "3210")]
        public void SolveForLengthTest(int length, int permutation, string expected)
        {
            Assert.AreEqual(expected, Problem24.SolveForLength(length, permutation));
        }
    }
}
