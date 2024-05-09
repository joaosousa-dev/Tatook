using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tatook.Domain.Entities.Customers;

namespace Tatook.Infrastructure.Data.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Email)
               .Property(x => x.Address)
               .HasColumnName("Email")
               .IsRequired(true);

            builder.OwnsOne(x => x.Name)
                .Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .IsRequired(true);

            builder.OwnsOne(x => x.Name)
                .Property(x => x.LastName)
                .HasColumnName("LastName")
                .IsRequired(true);

            builder.OwnsOne(x => x.Name)
            .Ignore(x => x.Notifications);

            builder.OwnsOne(x => x.Email)
            .Ignore(x => x.Notifications);


        }
    }
}
