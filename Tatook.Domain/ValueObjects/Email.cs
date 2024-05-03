using System.Text.RegularExpressions;
using Tatook.Shared.ValueObjects;

namespace Tatook.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Adreess { get; private set; }
        public Email(string adreess)
        {
            Adreess = adreess;
            Validate();
        }
        private void Validate()
        {
            bool isValid = Regex.IsMatch(Adreess, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isValid)
                AddNotification("Email adreess", "Email Adreess is invalid");
        }
    }
}
