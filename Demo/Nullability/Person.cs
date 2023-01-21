using System;

namespace Demo.Nullability
{
    public class Person
    {
#nullable disable
        private string emailAddress = null;
#nullable restore
        private string firstName = null!;
        private string lastName = null!;

        /// <summary>Gets or sets the <see cref="Person"/>'s email address.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }

        /// <summary>Gets or sets the <see cref="Person"/>'s first name.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string FirstName { get => firstName; set => firstName = value; }

        /// <summary>Gets or sets the <see cref="Person"/>'s last name.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string LastName { get => lastName; set => lastName = value; }

        public string? MiddleName { get; set; } = null;
        public float? Height { get; set; } = null;
        public CreditCard CreditCard { get; set; } = new CreditCard(null!);

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

#nullable disable warnings
        public CreditCard(string cardNumber)
        {
            CardNumber = null;
        }
#nullable restore
    }
}
