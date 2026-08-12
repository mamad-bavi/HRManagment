using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.FluentApi.Location
{
    public class OrganizationFluentApi : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable(nameof(Organization));

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.OrganCode)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(800);

            builder.Property(c => c.ProvinceId)
                .IsRequired();

            builder.Property(c => c.CityId)
                .IsRequired();

            builder.HasOne(c => c.Province)
                .WithMany(p => p.Organizations)
                .HasForeignKey(c => c.ProvinceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.City)
                .WithMany(p => p.Organizations)
                .HasForeignKey(c => c.CityId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
