using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tatook.Domain.Entities.Users;
using Tatook.Infrastructure.Data.Context;

namespace Tatook.Infrastructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly TatookDbContext _context;
        public UserRepository(TatookDbContext context)
        {
            _context = context;
        }

        public void Create(User entity)
        {
            _context.Add(entity);
            Save();
        }

        public bool EmailExists(string email)
        {
            return _context.Users.Any(x => x.Email.Address == email);
        }

        public async Task<IList<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
