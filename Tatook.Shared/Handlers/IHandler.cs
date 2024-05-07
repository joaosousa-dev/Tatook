using Tatook.Shared.Commands;

namespace Tatook.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        public ICommandResult Handle(T command);
    }
}
