using System;

namespace Demo.Immutability
{
    public sealed class MailingInfo : IEquatable<MailingInfo>
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

        public bool Equals(MailingInfo? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != GetType()) return false;

            return FullName == other.FullName
                && Address1 == other.Address1
                && City == other.City
                && Region == other.Region
                && PostalCode == other.PostalCode
                && Country == other.Country;
        }

        public static bool operator ==(MailingInfo? left, MailingInfo? right)
        {
            if (left is null) { return right is null; }
            return Equals(left, right);
        }

        public static bool operator !=(MailingInfo? left, MailingInfo? right)
        {
            return !(left == right);
        }

        public override bool Equals(object? other)
        {
            return Equals(other as MailingInfo);
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(FullName);
            hash.Add(Address1);
            hash.Add(City);
            hash.Add(Region);
            hash.Add(PostalCode);
            hash.Add(Country);

            return hash.ToHashCode();
        }
    }
}
