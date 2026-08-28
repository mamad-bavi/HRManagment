using Application.Contracts.GenericContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityGetListRepository:
        IRepositoryPublicAsyncDtoEFCore<City, CityGetListDto>

    {

    }
}
