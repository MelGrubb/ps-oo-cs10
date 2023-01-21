using NUnit.Framework;
using System.Drawing;

namespace Tests.EqualityTests
{
    [TestFixture]
    public class PointEqualityTests
    {
        [Test]
        public void Point_equality()
        {
            var a = new Point(1, 2);
            var b = new Point(1, 2);

            Assert.AreEqual(a, b);
            Assert.IsTrue(a == b);
        }
    }
}
