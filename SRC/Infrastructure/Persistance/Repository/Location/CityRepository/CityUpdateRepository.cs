using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepositories.Context;
using GenericRepositories.Repository.GenericRepository;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityUpdateRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityUpdateDto>,
        ICityUpdateRepository
    {
        public CityUpdateRepository(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }

    }
}
