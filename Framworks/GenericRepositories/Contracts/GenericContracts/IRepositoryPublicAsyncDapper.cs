using GenericRepositories.Filters;

namespace GenericRepositories.Contracts.GenericContract
{
    public interface IRepositoryPublicAsyncDapper<TEntity> where TEntity : class
    {
        
        Task<TEntity> GetByIdQueryAsync(long Id);
        Task<GreadData<TEntity>> GetByIdDeletedItemQueryAsync(long Id);
        Task<GreadData<TEntity>> GetByQueryAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByQueryDeletedItemsAsync(CancellationToken cancellationToken, GreadData<TEntity> data);
        Task<GreadData<TEntity>> GetByRangIdQuerAsync(List<long> Ids);
        Task<bool> AddByDapperAsync(TEntity entity);
        Task<bool> UpdateByDapperAsync(TEntity entity);

    }
}
