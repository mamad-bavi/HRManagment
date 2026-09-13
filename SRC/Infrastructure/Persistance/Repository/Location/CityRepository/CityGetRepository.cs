using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.Generic;
using GenericRepository.Repositories.GenericCleanArchitecture;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityGetRepository :
        RepositoryGet<City>,
        ICityGetRepository
    {
        //public CityGetByIdRepository(GenericCommandDbContext dbCommandContext,
        //    GenericQueryDbContext dbQueryContext, IMapper mapper) :
        //    base(dbCommandContext, dbQueryContext, mapper)
        //{
        //}
        public CityGetRepository(GenericQueryDbContext dbQueryContext, IMapper mapper) : 
            base(dbQueryContext, mapper)
        {
        }
    }
}
