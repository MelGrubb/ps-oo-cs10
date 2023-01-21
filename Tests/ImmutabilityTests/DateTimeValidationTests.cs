using NUnit.Framework;
using System;

namespace Tests.ImmutabilityTests
{
    [TestFixture]
    public class DateTimeValidationTests
    {
        [Test]
        public void DateTimes_are_self_validating()
        {
            var date1 = new DateTime(2000, 02, 29);
            Assert.IsNotNull(date1);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var date2 = new DateTime(2001, 02, 29);
                Assert.IsNotNull(date1);
            });
        }
    }
}
