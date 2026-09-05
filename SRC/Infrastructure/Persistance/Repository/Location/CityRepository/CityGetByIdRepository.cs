using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepositories.Context;
using GenericRepositories.Repositories.Generic;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityGetByIdRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityGetByIdDto>,
        ICityGetByIdRepository
    {
        public CityGetByIdRepository(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }

    }
}
