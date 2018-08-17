using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class FirstTests
    {

        public FirstTests()
        {
        }

        [Test]
        public void IsTrueResultTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void IsFalseResultTest()
        {
            Assert.IsFalse(false);
        }

        [Test]
        public void FailedTest()
        {
            Assert.IsTrue(false);
        }
    }
}
