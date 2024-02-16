using NUnit.Framework;

#pragma warning disable NUnit2015

namespace Tests.ImmutabilityTests
{
    [TestFixture]
    public class StringImmutabilityTests
    {
        [Test]
        public void Strings_are_immutable()
        {
            var string1 = "Hello";
            var string2 = string1;

            Assert.AreEqual(string1, string2);
            Assert.AreSame(string1, string2);

            string1 = string1 + " World";

            Assert.AreNotEqual(string1, string2); 
            Assert.AreNotSame(string1, string2);
        }
    }
}
