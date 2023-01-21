using System;

namespace Demo.Immutability
{
    public class MailingInfo
    {
        public string FullName { get; init; }
        public string Address1 { get; init; }
        public string? Address2 { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }

        public MailingInfo(string fullName, string address1, string city, string region, string postalCode, string country)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            ArgumentNullException.ThrowIfNull(address1);
            ArgumentNullException.ThrowIfNull(city);
            ArgumentNullException.ThrowIfNull(region);
            ArgumentNullException.ThrowIfNull(postalCode);
            ArgumentNullException.ThrowIfNull(country);

            FullName = fullName;
            Address1 = address1;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
