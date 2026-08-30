using Domain.Entities.Location;
using GenericRepositories.Contracts.GenericContract;
using GenericRepositories.Filters;

namespace Application.Contracts.Location.OrganizationContract
{
    public interface IOrganizationRepository : IRepositoryPublicAsyncEFCore<Organization>
    {
        Task<GreadData<Organization>> GetListByProvinceId(CancellationToken cancellationToken, GreadData<Organization> data);
        Task<GreadData<Organization>> GetListByCityId(CancellationToken cancellationToken, long cityId);
    }
}
