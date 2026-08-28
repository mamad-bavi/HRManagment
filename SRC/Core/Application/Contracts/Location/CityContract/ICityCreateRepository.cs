using Application.Contracts.GenericContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Location.CityContract
{
    public interface ICityCreateRepository : 
        IRepositoryPublicAsyncDtoEFCore<City,CityCreateDto>
    {

    }
}
