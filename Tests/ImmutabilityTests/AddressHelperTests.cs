using Demo.Immutability;
using NUnit.Framework;

namespace Tests.ImmutabilityTests
{
    [TestFixture]
    public class AddressHelperTests
    {
        [Test]
        public void FormatAddress_returns_properly_formatted_address()
        {
            var person = new Person("John", "Doe", 
                new Address("123 Any St.", null, "Anytown", "OH", "43210", "USA")
                { Address2 = "Suite 456"});
            var expected =
@"JOHN DOE
123 ANY ST.
SUITE 456
ANYTOWN, OH 43210
USA";
            var mailingInfo = new MailingInfo($"{person.FirstName} {person.LastName}", person.Address.Address1, person.Address.City, person.Address.Region, person.Address.PostalCode, person.Address.Country)
            { 
                Address2 = person.Address.Address2
            };
            Assert.AreEqual(expected, AddressHelper.FormatAddress(mailingInfo));
        }
    }
}
