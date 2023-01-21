using System.Text;

namespace Demo.Immutability
{
    public class AddressHelper
    {
        public static string FormatAddress(MailingInfo mailingInfo)
        {
            mailingInfo.FullName = mailingInfo.FullName.ToUpper();
            mailingInfo.Address1 = mailingInfo.Address1.ToUpper();
            mailingInfo.Address2 = mailingInfo.Address2?.ToUpper();
            mailingInfo.City = mailingInfo.City.ToUpper();
            mailingInfo.Region = mailingInfo.Region.ToUpper();
            mailingInfo.PostalCode = mailingInfo.PostalCode.ToUpper();
            mailingInfo.Country = mailingInfo.Country.ToUpper();

            var builder = new StringBuilder();
            builder.AppendLine($"{mailingInfo.FullName}");
            builder.AppendLine(mailingInfo.Address1);
            
            if (mailingInfo.Address2 != null) 
            { 
                builder.AppendLine(mailingInfo.Address2); 
            }

            builder.AppendLine($"{mailingInfo.City}, {mailingInfo.Region} {mailingInfo.PostalCode}");
            builder.Append(mailingInfo.Country);

            return builder.ToString();
        }
    }
}
