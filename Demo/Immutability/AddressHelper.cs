using System.Text;

namespace Demo.Immutability
{
    public class AddressHelper
    {
        public static string FormatAddress(MailingInfo mailingInfo)
        {
            var fullName = mailingInfo.FullName.ToUpper();
            var address1 = mailingInfo.Address1.ToUpper();
            var address2 = mailingInfo.Address2?.ToUpper();
            var city = mailingInfo.City.ToUpper();
            var region = mailingInfo.Region.ToUpper();
            var postalCode = mailingInfo.PostalCode.ToUpper();
            var country = mailingInfo.Country.ToUpper();

            var builder = new StringBuilder();
            builder.AppendLine(fullName);
            builder.AppendLine(address1);
            
            if (address2 != null) 
            { 
                builder.AppendLine(address2); 
            }

            builder.AppendLine($"{city}, {region} {postalCode}");
            builder.Append(country);

            return builder.ToString();
        }
    }
}
