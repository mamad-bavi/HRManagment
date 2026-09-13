using Application.DTOs.Location.CityDtos.CommandDtos;
using Domain.Entities.Location;
using GenericRepository.Contracts.Generic;
using GenericRepository.Contracts.GenericCleanArchitecture;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityUpdateRepository : 
        IRepositoryUpdate<City>
    {
    }
}
