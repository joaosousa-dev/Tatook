using Flunt.Notifications;
using System.Net;
using Tatook.Domain.Commands;
using Tatook.Domain.Entities.Users;
using Tatook.Shared.Commands;
using Tatook.Shared.Handlers;

namespace Tatook.Domain.Handlers
{
    public class CreateUserHandler : IHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ICommandResult Handle(CreateUserCommand command)
        {
            var user = command.ToDomain();

            bool emailExists = _userRepository.EmailExists(user.Email.Address);
            if (emailExists)
                user.AddNotification("User.Email", "Email already exists");

            if (user.IsValid)
            {
                _userRepository.Create(user);
                return new CommandResult(HttpStatusCode.OK, true, "User created sucessfull");
            }
            return new CommandResult(HttpStatusCode.UnprocessableEntity, false, user.Notifications);

        }
    }
}
