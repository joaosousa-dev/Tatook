using Tatook.Domain.Entities.Companies;
using Tatook.Shared.Commands;

namespace Tatook.Domain.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
