using System;

#nullable enable

namespace Demo.Nullability
{
    public class Person
    {
        private string _emailAddress = null!;
        private string _firstName = null!;
        private string _lastName = null!;

        /// <summary>Gets or sets the <see cref="Person"/>'s email address.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string EmailAddress
        {
            get => _emailAddress;
            set => _emailAddress = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>Gets or sets the <see cref="Person"/>'s first name.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>Gets or sets the <see cref="Person"/>'s last name.</summary>
        /// <exception cref="ArgumentNullException">Thrown if the property is set to a null value.</exception>
        public string LastName
        {
            get => _lastName;
            set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
        }

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
