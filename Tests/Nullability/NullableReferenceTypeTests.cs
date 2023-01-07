using Demo.Nullability;
using NUnit.Framework;

#nullable disable

namespace Tests.Nullability
{
    [TestFixture]
    public class NullableReferenceTypeTests
    {
        [Test]
        public void Setting_EmailAddress_to_null()
        {
            var person = new Person(null, "John", "Doe");
            Assert.IsNull(person.EmailAddress);
        }
    }
}
