using Application.DTOs.Location.CityDtos.QueryDtos;
using Domain.Entities.Location;
using GenericRepository.Contracts.GenericCleanArchitecture;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityGetRepository :
        IRepositoryGet<City>
    {
    }
}
