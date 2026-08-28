using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using Microsoft.Extensions.Configuration;
using Persistance.Context;
using Persistance.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityCreateRepository : 
        RepositoryPublicAsyncDtoEFCore<City, CityCreateDto> ,
        ICityCreateRepository
        
    {
        public CityCreateRepository(HRDbContext dbContext, IMapper mapper) : 
            base(dbContext, mapper)
        {
        }



    }
}
