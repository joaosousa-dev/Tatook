using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatook.Domain.Entities;
using Tatook.Domain.ValueObjects;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Customers
{
    public class Customer : BaseEntity
    {
        protected Customer()
        {
            //EF CORE
        }
        public Customer(Name name, Email email)
        {
            Name = name;
            Email = email;
            Validate();
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }

        private void Validate()
        {
            AddNotifications(Name, Email);
        }
    }
}
