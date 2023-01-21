using NUnit.Framework;

namespace Tests.EqualityTests
{
    [TestFixture]
    public class IntegerEqualityTests
    {
        [Test]
        public void Integer_equality()
        {
            var a = 2 * 2;
            var b = 8 / 2;

            Assert.AreEqual(a, b);
            Assert.IsTrue(a == b);
        }
    }
}
