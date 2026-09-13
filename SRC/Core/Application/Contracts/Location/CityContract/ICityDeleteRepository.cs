using Domain.Entities.Location;
using GenericRepository.Contracts.GenericCleanArchitecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityDeleteRepository :
        IRepositoryDelete<City>
    {
    }
}
