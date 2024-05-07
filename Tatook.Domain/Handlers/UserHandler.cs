using Flunt.Notifications;
using Tatook.Domain.Commands;
using Tatook.Domain.Entities.Users;
using Tatook.Shared.Commands;
using Tatook.Shared.Handlers;

namespace Tatook.Domain.Handlers
{
    public class UserHandler :
        Notifiable<Notification>,
        IHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ICommandResult Handle(CreateUserCommand command)
        {
            bool emailExists = _userRepository.EmailExists(command.EmailAddress);
            if (emailExists)
            {
                AddNotification("Email", "Email already exists");
            }
            return new CommandResult(true,"User created sucessfull");
        }
    }
}
