using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tatook.Domain.Entities.Subscriptions;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Infrastructure.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);

            builder.Property(x => x.PhotoUrl)
                .HasColumnName("PhotoUrl")
                .HasColumnType("NVARCHAR");

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

            builder.HasOne(x => x.Company)
               .WithMany(x => x.Employees)
               .HasConstraintName("FK_User_Company");

            builder.HasMany(x => x.Quotes)
              .WithOne(x => x.User) 
              .HasConstraintName("FK_User_Quotes");

            builder.HasOne(x => x.Subscription)
              .WithOne(x=> x.User)
              .HasForeignKey<Subscription>("UserId");
        }
    }
}
