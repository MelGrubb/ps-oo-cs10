namespace Demo.Immutability
{
    public record MailingInfo(string FullName, string Address1, string? Address2, string City, string Region, string PostalCode, string Country);
}