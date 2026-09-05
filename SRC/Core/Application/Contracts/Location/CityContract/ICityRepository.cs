
using Domain.Entities.Location;
using GenericRepositories.Contracts.Generic;
using GenericRepositories.ParentEntities;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityRepository : 
        IRepositoryPublicAsyncEFCore<City>
    {

    }
}
