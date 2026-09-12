using Application.DTOs.Location.CityDtos.QueryDtos;
using Domain.Entities.Location;
using GenericRepository.Contracts.Generic;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityGetListRepository:
        IRepositoryPublicAsyncDtoEFCore<City, CityGetListDto>

    {

    }
}
