using Microsoft.EntityFrameworkCore;
using Tatook.Domain.Entities.Users;
using Tatook.Infrastructure.Data.Mapping;

namespace Tatook.Infrastructure.Data.Context
{
    public class TatookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tatook;User ID=sa;Password=J040v1ct0r!");
        }
    }
}
