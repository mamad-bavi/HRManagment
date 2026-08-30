using Application.DTOs.Location.CityDtos.QueryDtos;
using Domain.Entities.Location;
using GenericRepositories.Contracts.GenericContract;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityGetByIdRepository :
        IRepositoryPublicAsyncDtoEFCore<City, CityGetByIdDto>
    {
    }
}
