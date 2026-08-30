using AutoMapper;
using GenericRepositories.Context;
using GenericRepositories.Contracts.GenericContract;
using GenericRepositories.ParentEntities;
using GenericRepositories.Utilities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace GenericRepositories.Repository.GenericRepository
{
    public class RepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById, TDtoList> :
        RepositoryPublicAsyncEFCore<TEntity>,
        IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById, TDtoList> where TEntity : class ,IBaseEntity
        
    {
        private readonly IMapper mapper;

        public RepositoryPublicAsyncDtoEFCore(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext,IMapper mapper) : base(dbCommandContext,dbQueryContext)
        {
            this.mapper = mapper;
        }


        public virtual async Task<IEnumerable<TDtoList>> GetDtos(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken)
        {
            var list = await TableNoTracking.Where(predicate)
                .ToListAsync(cancellationToken);

            var dtoList = list.ConvertListObject<TDtoList, TEntity>(mapper);
            return dtoList;
        }

        public virtual async Task AddDtoAsync(TDtoCreate dto, CancellationToken cancellationToken, bool saveNow = true)
        {
            var entity = dto.ConvertObject<TEntity, TDtoCreate>(mapper);
            await base.AddAsync(entity, cancellationToken, saveNow);

        }


        public virtual async Task UpdateDtoAsync(TDtoUpdate dto, CancellationToken cancellationToken, bool saveNow = true)
        {
            var entity = dto.ConvertObject<TEntity, TDtoUpdate>(mapper);
            await base.UpdateAsync(entity, cancellationToken, saveNow);
        }

        public virtual async Task<TDtoGetById> GetDtoById<TKey>(TKey Id, CancellationToken cancellationToken)
        {
            var idProperty = typeof(TEntity).GetProperties()
                .Where(p => p.GetCustomAttribute<KeyAttribute>() != null)
                .Select(p => p.Name)
                .FirstOrDefault();
            var Item = await TableNoTracking.FirstOrDefaultAsync(e =>
            EF.Property<TKey>(e, idProperty).Equals(Id), cancellationToken);
            var dto = Item.ConvertObject<TDtoGetById, TEntity>(mapper);
            return dto;
        }

    }

    public class RepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
    TDtoUpdate, TDtoGetById> : RepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById, TDtoGetById>,
        IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById> where TEntity : class ,
        IBaseEntity
    {
        public RepositoryPublicAsyncDtoEFCore(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext,dbQueryContext, mapper)
        {
        }
    }

    public class RepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
    TDtoGetById> : RepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoCreate, TDtoGetById>,
        IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoGetById> where TEntity : class ,
        IBaseEntity
    {
        public RepositoryPublicAsyncDtoEFCore(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext,dbQueryContext, mapper)
        {
        }
    }

    public class RepositoryPublicAsyncDtoEFCore<TEntity, TDto> : 
        RepositoryPublicAsyncDtoEFCore<TEntity, TDto, TDto>,
        IRepositoryPublicAsyncDtoEFCore<TEntity, TDto> where TEntity : class,
        IBaseEntity
    {
        public RepositoryPublicAsyncDtoEFCore(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }
        
    }

}
