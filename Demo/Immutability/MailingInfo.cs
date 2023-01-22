using System;

namespace Demo.Immutability
{
    public record MailingInfo
    {
        public string FullName { get; init; }
        public string Address1 { get; init; }
        public string? Address2 { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }

        public MailingInfo(string FullName, string Address1, string City, string Region, string PostalCode, string Country)
        {
            this.FullName = FullName ?? throw new ArgumentNullException(nameof(FullName));
            this.Address1 = Address1 ?? throw new ArgumentNullException(nameof(Address1));
            this.City = City ?? throw new ArgumentNullException(nameof(City));
            this.Region = Region ?? throw new ArgumentNullException(nameof(Region));
            this.PostalCode = PostalCode ?? throw new ArgumentNullException(nameof(PostalCode));
            this.Country = Country ?? throw new ArgumentNullException(nameof(Country));
        }

        public virtual bool Equals(MailingInfo? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;

            var result = FullName == other.FullName
                && Address1 == other.Address1
                && City == other.City
                && Region == other.Region
                && PostalCode == other.PostalCode
                && Country == other.Country;

            return result;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, Address1, City, Region, PostalCode, Country);
        }
    }
}
