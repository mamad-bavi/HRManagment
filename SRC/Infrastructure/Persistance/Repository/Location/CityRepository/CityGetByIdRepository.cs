using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.Generic;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityGetByIdRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityGetByIdDto>,
        ICityGetByIdRepository
    {
        //public CityGetByIdRepository(GenericCommandDbContext dbCommandContext,
        //    GenericQueryDbContext dbQueryContext, IMapper mapper) :
        //    base(dbCommandContext, dbQueryContext, mapper)
        //{
        //}
        public CityGetByIdRepository(GenericCommandDbContext dbCommandContext, 
            GenericQueryDbContext dbQueryContext, IMapper mapper) : 
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }
    }
}
