using SecureIdentity.Password;
using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Quotes;
using Tatook.Domain.ValueObjects;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public User(Name name, Email email, Company? company, IList<Quote>? quotes = null, string? photoUrl = null)
        {
            var password = PasswordGenerator.Generate(25);
            PasswordHash = PasswordHasher.Hash(password);
            Name = name;
            Email = email;
            Quotes = quotes;
            Company = company;
            PhotoUrl = photoUrl;

            AddNotifications(name, email,company);
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string PasswordHash { get; private set; }
        public IList<Quote>? Quotes { get; private set; }
        public Company? Company { get; private set; }
        public string? PhotoUrl { get; set; }

        public void UpdateEmail(string email) 
        {
            Email = new Email(email);
        }

        public void UpdateCompany(Company company)
        {
            Company = company;
        }

    }
}
