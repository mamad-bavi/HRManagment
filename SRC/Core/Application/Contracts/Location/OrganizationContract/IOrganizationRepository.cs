using Domain.Entities.Location;
using GenericRepository.Contracts.Generic;
using GenericRepository.Filters;

namespace Application.Contracts.Location.OrganizationContract
{
    public interface IOrganizationRepository : IRepositoryPublicAsyncEFCore<Organization>
    {
        Task<GreadData<Organization>> GetListByProvinceId(CancellationToken cancellationToken, GreadData<Organization> data);
        Task<GreadData<Organization>> GetListByCityId(CancellationToken cancellationToken, long cityId);
    }
}
