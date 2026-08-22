using Application.Contracts.GenericContract;
using Application.Utilities.AutoMapperGeneric;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Persistance.Repository.GenericRepository
{
    public class RepositoryPublicAsyncDtoEFCore<TEntity> :
        RepositoryPublicAsyncEFCore<TEntity>,
        IRepositoryPublicAsyncDtoEFCore<TEntity> where TEntity : class , 
        IBaseEntity
    {
        public RepositoryPublicAsyncDtoEFCore(HRDbContext dbContext, IConfiguration configuration) : base(dbContext, configuration)
        {
        }

        public async Task<IEnumerable<TDto>> GetDtos<TDto>(CancellationToken cancellationToken)
        {
            var list = await TableNoTracking.ToListAsync(cancellationToken);
            var dtoList = list.ConvertListObject<TDto, TEntity>();
            return dtoList;
        }

        public async Task<IEnumerable<TDto>> GetDtos<TDto>(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken)
        {
            var list = await TableNoTracking.Where(predicate)
                .ToListAsync(cancellationToken);

            var dtoList = list.ConvertListObject<TDto, TEntity>();
            return dtoList;
        }

        public async Task AddAsync<TDto>(TDto dto, CancellationToken cancellationToken, bool saveNow = true)
        {
            var entity = dto.ConvertObject<TEntity, TDto>();
            await base.AddAsync(entity, cancellationToken, saveNow);

        }


        public Task UpdateAsync<TDto>(TDto dto, CancellationToken cancellationToken, bool saveNow = true)
        {
            throw new NotImplementedException();
        }

        public async Task<TDto> GetDtoById<TDto, TKey>(TKey Id, CancellationToken cancellationToken)
        {
            var Item = await TableNoTracking.FirstOrDefaultAsync(e =>
            EF.Property<TKey>(e, "Id").Equals(Id), cancellationToken);
            var dto = Item.ConvertObject<TDto, TEntity>();
            return dto;
        }



    }
}
