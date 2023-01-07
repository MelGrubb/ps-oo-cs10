using Demo.Nullability;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
