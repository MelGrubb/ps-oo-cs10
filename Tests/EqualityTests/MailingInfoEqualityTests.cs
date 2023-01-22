using Demo.Immutability;
using NUnit.Framework;

namespace Tests.EqualityTests
{
    [TestFixture]
    public class MailingInfoEqualityTests
    {
        [Test]
        public void MailingInfo_equality()
        {
            var info1 = new MailingInfo("John Doe", "123 Any St.", "Suite 456", "Anytown", "OH", "43210", "USA");
            var info2 = new MailingInfo("John Doe", "123 Any St.", "Apt A", "Anytown", "OH", "43210", "USA");

            Assert.AreEqual(info1, info2);
            Assert.AreEqual((object)info1, (object)info2);
            Assert.IsTrue(info1 == info2);
            Assert.AreNotSame(info1, info2);
            Assert.AreEqual(info1.GetHashCode(), info2.GetHashCode());
        }
    }
}
