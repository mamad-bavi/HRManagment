using Application.DTOs.Location.CityDtos.CommandDtos;
using Domain.Entities.Location;
using GenericRepositories.Contracts.GenericContract;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityUpdateRepository : 
        IRepositoryPublicAsyncDtoEFCore<City, CityUpdateDto>
    {
    }
}
