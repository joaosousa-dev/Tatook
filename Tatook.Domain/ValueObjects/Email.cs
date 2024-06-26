﻿using Flunt.Validations;
using Tatook.Shared.ValueObjects;

namespace Tatook.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; private set; }

        public Email(string adreess)
        {
            Address = adreess;
            Validate();
        }
        protected Email() { }

        private void Validate()
        {
            AddNotifications(new Contract<Email>()
                .Requires()
                .IsEmail(Address, "Email")
                );
        }
    }
}
