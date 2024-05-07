using Tatook.Domain.Intefaces;

namespace Tatook.Domain.Entities.Users
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        public bool EmailExists(string email);
    }
}
