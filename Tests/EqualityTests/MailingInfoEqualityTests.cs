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
            var info1 = new MailingInfo("John Doe", "123 Any St.", "Anytown", "OH", "43210", "USA");
            var info2 = new MailingInfo("John Doe", "123 Any St.", "Anytown", "OH", "43210", "USA");

            Assert.AreNotEqual(info1, info2);
            Assert.AreNotSame(info1, info2);
        }
    }
}
