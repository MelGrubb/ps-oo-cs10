using System.Text;

namespace Demo.Immutability
{
    public class AddressHelper
    {
        public static string FormatAddress(MailingInfo mailingInfo)
        {
            var normalized = NormalizeAddress(mailingInfo) with
            {
                FullName = mailingInfo.FullName.ToUpper(),
            };

            var builder = new StringBuilder();
            builder.AppendLine(normalized.FullName);
            builder.AppendLine(normalized.Address1);

            if (normalized.Address2 != null)
            {
                builder.AppendLine(normalized.Address2);
            }

            builder.AppendLine($"{normalized.City}, {normalized.Region} {normalized.PostalCode}");
            builder.Append(normalized.Country);

            return builder.ToString();
        }

        private static MailingInfo NormalizeAddress(MailingInfo mailingInfo)
        {
            return mailingInfo with
            {
                Address1 = mailingInfo.Address1.ToUpper(),
                Address2 = mailingInfo.Address2?.ToUpper(),
                City = mailingInfo.City.ToUpper(),
                Region = mailingInfo.Region.ToUpper(),
                PostalCode = mailingInfo.PostalCode.ToUpper(),
                Country = mailingInfo.Country.ToUpper(),
            };
        }
    }
}
