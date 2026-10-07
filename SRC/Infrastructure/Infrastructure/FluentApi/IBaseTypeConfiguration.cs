using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.FluentApi
{
    public interface IBaseTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
    }
}
