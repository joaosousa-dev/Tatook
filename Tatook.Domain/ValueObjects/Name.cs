using Tatook.Shared.ValueObjects;

namespace Tatook.Domain.ValueObjects
{
    public class Name : ValueObject
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Validate();
        }
        
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                AddNotification("FirstName", "Name is required");
            if (string.IsNullOrWhiteSpace(LastName))
                AddNotification("LastName", "Name is required");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
