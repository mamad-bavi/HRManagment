using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Application.Contracts.GenericContract
{
    public interface IRepositoryPublicAsyncDtoEFCore<TEntity>:
        IRepositoryPublicAsyncEFCore<TEntity> where TEntity : class
        , IBaseEntity
    {
       
        Task AddAsync<TDto>(TDto dto, CancellationToken cancellationToken, bool saveNow = true);
        Task UpdateAsync<TDto>(TDto dto, CancellationToken cancellationToken, bool saveNow = true);
        Task<TDto> GetDtoById<TDto, TKey>(TKey Id, CancellationToken cancellationToken);
        Task<IEnumerable<TDto>> GetDtos<TDto>(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    }
}
