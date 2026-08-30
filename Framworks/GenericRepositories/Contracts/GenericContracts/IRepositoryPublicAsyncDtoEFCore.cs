using GenericRepositories.ParentEntities;
using System.Linq.Expressions;

namespace GenericRepositories.Contracts.GenericContract
{
    public interface IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate, 
        TDtoUpdate, TDtoGetById, TDtoList> :
        IRepositoryPublicAsyncEFCore<TEntity> where TEntity : class 
        
    {
       
        Task AddDtoAsync(TDtoCreate dto, CancellationToken cancellationToken, bool saveNow = true);
        Task UpdateDtoAsync(TDtoUpdate dto, CancellationToken cancellationToken, bool saveNow = true);
        Task<TDtoGetById> GetDtoById<TKey>(TKey Id, CancellationToken cancellationToken);
        Task<IEnumerable<TDtoList>> GetDtos(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    }


    public interface IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById> : IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoUpdate, TDtoGetById, TDtoGetById> where TEntity : class,
        IBaseEntity
    {

    }

    public interface IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
         TDtoGetById> : IRepositoryPublicAsyncDtoEFCore<TEntity, TDtoCreate,
        TDtoCreate, TDtoGetById, TDtoGetById> where TEntity : class,
        IBaseEntity
    {

    }

    public interface IRepositoryPublicAsyncDtoEFCore<TEntity, TDto> 
        : IRepositoryPublicAsyncDtoEFCore<TEntity, TDto,
        TDto, TDto, TDto> where TEntity : class,
        IBaseEntity
    {

    }

}
