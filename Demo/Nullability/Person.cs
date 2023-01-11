using System;

#nullable enable

namespace Demo.Nullability
{
    public class Person
    {
        private string emailAddress = null!;
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
        public CreditCard? CreditCard { get; set; } = null;

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
