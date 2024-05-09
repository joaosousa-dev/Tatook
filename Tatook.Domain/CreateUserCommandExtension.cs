using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatook.Domain.Commands;
using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Domain
{
    public static class CreateUserCommandExtension
    {
        public static User ToDomain(this CreateUserCommand command) =>
            new User
            (
                new Name(command.FirstName, command.LastName),
                new Email(command.EmailAddress)
            );


    }
}
