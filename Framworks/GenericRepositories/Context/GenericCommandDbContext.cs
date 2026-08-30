using GenericRepositories.ParentEntities;
using GenericRepositories.Utilities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GenericRepositories.Context
{
    public class GenericCommandDbContext : DbContext
    {
        private readonly Assembly[] _assemblies;

        public GenericCommandDbContext(DbContextOptions<GenericCommandDbContext> options,
            params Assembly[] assemblies)
            : base(options)
        {
            _assemblies = assemblies;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var assembly in _assemblies)
            {
                modelBuilder.RegisterAllEntities<IBaseEntity>(assembly);
                modelBuilder.RegisterEntityTypeConfiguration(assembly);
            }

            modelBuilder.AddRestrictDeleteBehaviorConvention();
            modelBuilder.AddSequentialGuidForIdConvention();

        }
    }
}
