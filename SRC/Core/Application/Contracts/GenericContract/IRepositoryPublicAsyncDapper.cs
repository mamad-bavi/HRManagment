using Application.Filters;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.GenericContract
{
    public interface IRepositoryPublicAsyncDapper<TEntity> where TEntity : class,IBaseEntity
    {
        
        Task<TEntity> GetByIdQueryAsync(long Id);
        Task<GreadData<TEntity>> GetByIdDeletedItemQueryAsync(long Id);
        Task<GreadData<TEntity>> GetByQueryAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByQueryDeletedItemsAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByRangIdQuerAsync(List<long> Ids);

    }
}
