using NUnit.Framework;

namespace NUnitTestsProject
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
    }
}
