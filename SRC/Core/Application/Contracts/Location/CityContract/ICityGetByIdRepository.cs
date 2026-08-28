using Application.Contracts.GenericContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityGetByIdRepository :
        IRepositoryPublicAsyncDtoEFCore<City, CityGetByIdDto>
    {
    }
}
