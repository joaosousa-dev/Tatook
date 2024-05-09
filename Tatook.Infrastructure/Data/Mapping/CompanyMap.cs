using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Infrastructure.Data.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreateDate)
                .HasColumnName("CreateDate")
                .HasColumnType("DATETIME")
                .IsRequired(true);

            builder.Property(x => x.UpdateDate)
               .HasColumnName("UpdateDate")
               .HasColumnType("DATETIME");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .IsRequired(true);

            builder.Property(x => x.LogoLink)
                .HasColumnName("LogoLink")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);

            builder.HasOne(x => x.Owner);

            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Company);
        }
    }
}
