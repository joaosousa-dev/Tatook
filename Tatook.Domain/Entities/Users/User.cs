using Flunt.Validations;
using SecureIdentity.Password;
using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Quotes;
using Tatook.Domain.Entities.Subscriptions;
using Tatook.Domain.ValueObjects;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        protected User()
        {
        }
        public User(Name name, Email email, Company? company = null, IList<Quote>? quotes = null, string? photoUrl = null, Subscription? subscription = null)
        {
            PasswordHash = PasswordHasher.Hash(PasswordGenerator.Generate(25));
            Name = name;
            Email = email;
            Quotes = quotes;
            Company = company;
            PhotoUrl = photoUrl;
            Subscription = subscription;
            Validate();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string PasswordHash { get; private set; }
        public IList<Quote>? Quotes { get; private set; }
        public Company? Company { get; private set; }
        public string? PhotoUrl { get; private set; }
        public Subscription? Subscription { get; private set; }

        public void UpdateEmail(Email email)
        {
            if (Email.Address == email.Address)
            {
                Email.AddNotification("User.Email", "New Email must be different than old email");
                AddNotifications(Email);
                return;
            }
            Email = email;
        }

        public void UpdateCompany(Company company)
        {
            if (company.IsValid)
                Company = company;
        }
        public void AddSubscription(Subscription subscription)
        {
            if (subscription.IsValid)
                Subscription = subscription;
        }
        public void Validate()
        {
            AddNotifications(Name, Email);
        }


    }
}
