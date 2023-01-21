namespace Demo.Immutability
{
    public class Address
    {
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address(string address1, string? address2, string city, string region, string postalCode, string country)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
