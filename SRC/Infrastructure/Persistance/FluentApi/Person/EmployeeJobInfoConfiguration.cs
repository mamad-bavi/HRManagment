using Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.FluentApi.Person
{
    public class EmployeeJobInfoConfiguration
    : IEntityTypeConfiguration<EmployeeJobInfo>
    {
        public void Configure(EntityTypeBuilder<EmployeeJobInfo> builder)
        {
            builder.HasKey(x => x.Id);

            // Employee -> JobInfos
            builder.HasOne(x => x.Employee)
                   .WithMany(x => x.JobInfos)
                   .HasForeignKey(x => x.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Manager -> EmployeeJobInfos
            builder.HasOne(x => x.Manager)
                   .WithMany()
                   .HasForeignKey(x => x.ManagerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Department
            builder.HasOne(x => x.Department)
                   .WithMany()
                   .HasForeignKey(x => x.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Position
            builder.HasOne(x => x.Position)
                   .WithMany()
                   .HasForeignKey(x => x.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            // JobGrade
            builder.HasOne(x => x.JobGrade)
                   .WithMany()
                   .HasForeignKey(x => x.JobGradeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
