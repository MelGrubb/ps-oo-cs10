#nullable enable

namespace Demo.Nullability
{
    public class Person
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public CreditCard CreditCard { get; set; }

        public Person(string emailAddress, string firstName, string lastName)
        {
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class CreditCard
    {
        public string CardNumber { get; set; }

        public CreditCard(string cardNumber)
        {
            CardNumber = cardNumber;
        }
    }
}
