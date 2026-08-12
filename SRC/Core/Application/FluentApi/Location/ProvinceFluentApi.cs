using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.FluentApi.Location
{
    public class ProvinceFluentApi : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable(nameof(Province));

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(c => c.Cities)
               .WithOne(c => c.Province)
               .HasForeignKey(c => c.ProvinceId);

            builder.HasMany(c => c.Organizations)
               .WithOne(c => c.Province)
               .HasForeignKey(c => c.ProvinceId);

        }
    }
}
