using NUnit.Framework;
namespace Problems.Tests
{
    [TestFixture()]
    public class Problem26Tests
    {
 
        [Test()]
        public void CycleLengthTest()
        {
            Assert.AreEqual(6, Problem26.CycleLength(7));
        }
    }
}
