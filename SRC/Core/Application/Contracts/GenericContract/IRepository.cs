using Application.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;

namespace Application.Contracts.GenericContract
{
    public interface IRepository<TEntity> where TEntity : class , new()
    {
        DbSet<TEntity> Entities { get; }
        IQueryable<TEntity> TableDeleted { get; }
        IQueryable<TEntity> TableNoTrackingDeleted { get; }
        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> TableNoTracking { get; }

        void Add(TEntity entity, bool saveNow = true);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
        void AddRange(IEnumerable<TEntity> entities, bool saveNow = true);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
        void Attach(TEntity entity);
        void Delete(TEntity entity, bool saveNow = true);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
        void DeleteRange(IEnumerable<TEntity> entities, bool saveNow = true);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
        void Detach(TEntity entity);
        TEntity GetById(params object[] ids);
        TEntity GetByIdDeleted(params object[] ids);
        Task<TEntity> GetByIdAsync(CancellationToken cancellationToken, params object[] ids);
        Task<GreadData<TEntity>> GetListAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<TEntity> GetByIdDeletedAsync(CancellationToken cancellationToken, params object[] ids);
        Task<GreadData<TEntity>> GetDeletedAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        void LoadCollection<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> collectionProperty) where TProperty : class;
        Task LoadCollectionAsync<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> collectionProperty, CancellationToken cancellationToken) where TProperty : class;
        void LoadReference<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> referenceProperty) where TProperty : class;
        Task LoadReferenceAsync<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> referenceProperty, CancellationToken cancellationToken) where TProperty : class;
        void Update(TEntity entity, bool saveNow = true);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true);
        void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true);
        Task<GreadData<TEntity>> GetByIdQuerAsync(long Id);
        Task<GreadData<TEntity>> GetByIdQuerDeletedItemAsync(long Id);
        Task<GreadData<TEntity>> GetByQueryAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByQueryDeletedItemsAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByRangIdQuerAsync(List<long> Ids);
        Task AddAsync<TDto,TEntity>(TDto dto, CancellationToken cancellationToken, bool saveNow = true);
        Task UpdateAsync<TDto,TEntity>(TDto dto, CancellationToken cancellationToken, bool saveNow = true);
        Task<IEnumerable<TDto>> GetDtoById<TDto, TEntity, TKey>(TKey Id, CancellationToken cancellationToken);
        Task<IEnumerable<TDto>> GetDtos<TDto,TEntit>(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    }
}
