
using Domain.Entities.Location;
using GenericRepository.Contracts.Generic;
using GenericRepository.ParentEntities;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityRepository : 
        IRepositoryPublicAsyncEFCore<City>
    {

    }
}
