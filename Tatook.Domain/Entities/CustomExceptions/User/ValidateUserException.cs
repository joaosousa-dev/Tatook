using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatook.Domain.Entities.CustomExceptions.User
{
    public class ValidateUserException : Exception
    {
        public string ErrorCode { get; private set; }
        public ValidateUserException(string errorCode, string message = "Invalid User")
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
