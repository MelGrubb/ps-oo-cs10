using System.Text;

namespace Demo.Immutability
{
    public class AddressHelper
    {
        public static string FormatAddress(Person person)
        {
            person.FirstName = person.FirstName.ToUpper();
            person.LastName = person.LastName.ToUpper();
            person.Address.Address1 = person.Address.Address1.ToUpper();
            person.Address.Address2 = person.Address.Address2?.ToUpper();
            person.Address.City = person.Address.City.ToUpper();
            person.Address.Region = person.Address.Region.ToUpper();
            person.Address.PostalCode = person.Address.PostalCode.ToUpper();
            person.Address.Country = person.Address.Country.ToUpper();

            var builder = new StringBuilder();
            builder.AppendLine($"{person.FirstName} {person.LastName}");
            builder.AppendLine(person.Address.Address1);
            
            if (person.Address.Address2 != null) 
            { 
                builder.AppendLine(person.Address.Address2); 
            }

            builder.AppendLine($"{person.Address.City}, {person.Address.Region} {person.Address.PostalCode}");
            builder.Append(person.Address.Country);

            return builder.ToString();
        }
    }
}
