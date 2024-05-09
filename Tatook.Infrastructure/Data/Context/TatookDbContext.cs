using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;
using Tatook.Infrastructure.Data.Mapping;
using Tatook.Shared.ValueObjects;

namespace Tatook.Infrastructure.Data.Context
{
    public class TatookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notifiable<Notification>>();
            modelBuilder.Ignore<Notification>();

            modelBuilder.Owned<ValueObject>();
            //modelBuilder.Owned<Name>();
            //modelBuilder.Owned<Email>();


            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Tatook;User ID=sa;Password=J040v1ct0r!");
        }
    }
}
