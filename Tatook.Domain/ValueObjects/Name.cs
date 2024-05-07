using Flunt.Validations;
using Tatook.Shared.ValueObjects;

namespace Tatook.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        protected Name() { }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Validate();
        }

        public void Validate()
        {
            AddNotifications(new Contract<Name>()
                .Requires()
                .IsNotNullOrWhiteSpace(FirstName, "FirstName", "FirstName is required")
                .IsNotNullOrWhiteSpace(LastName, "LastName", "LastName is required")
                .IsLowerThan(FirstName,20, "FirstName", "FirstName shold be lower than 20 characters")
                .IsLowerThan(LastName, 20, "LastName", "LastName shold be lower than 20 characters")
            );
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
