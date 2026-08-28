using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Application.DTOs.Location.CityDtos.QueryDtos;
using AutoMapper;
using Domain.Entities.Location;
using Persistance.Context;
using Persistance.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityGetByIdRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityGetByIdDto>,
        ICityGetByIdRepository
    {
        public CityGetByIdRepository(HRDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

    }
}
