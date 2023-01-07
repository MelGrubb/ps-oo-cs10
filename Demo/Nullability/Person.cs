#nullable disable

namespace Demo.Nullability
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public CreditCard CreditCard { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }

        public CreditCard(string cardNumber)
        {
            CardNumber = cardNumber;
        }
    }
}
