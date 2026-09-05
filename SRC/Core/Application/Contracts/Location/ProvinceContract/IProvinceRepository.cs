using Domain.Entities.Location;
using GenericRepositories.Contracts.Generic;

namespace Application.Contracts.Location.ProvinceContract
{
    public interface IProvinceRepository: IRepositoryPublicAsyncEFCore<Province>
    {
        Task<bool> Exist(long id);
    }
}
