using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.Generic;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityCreateRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityCreateDto>,
        ICityCreateRepository

    {
        //public CityCreateRepository(GenericCommandDbContext dbCommandContext,
        //    GenericQueryDbContext dbQueryContext, IMapper mapper) :
        //    base(dbCommandContext, dbQueryContext, mapper)
        //{
        //}
        public CityCreateRepository(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) : 
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }
    }
}
