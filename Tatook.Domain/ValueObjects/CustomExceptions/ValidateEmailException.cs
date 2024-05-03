using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tatook.Domain.ValueObjects.CustomExceptions
{
    public partial class ValidateEmailException : Exception
    {
        private const string defaultErrorMessage = "Email is invalid";
        public ValidateEmailException(string address, string message = defaultErrorMessage)
            : base(message)
        {
        }

        public static void Validate(string address)
        {
            bool isValid = Regex.IsMatch(address, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isValid)
                throw new ValidateEmailException(address);
        }
    }
}
