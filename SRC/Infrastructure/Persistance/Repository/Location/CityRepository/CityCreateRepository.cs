using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepositories.Context;
using GenericRepositories.Repository.GenericRepository;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityCreateRepository : 
        RepositoryPublicAsyncDtoEFCore<City, CityCreateDto> ,
        ICityCreateRepository
        
    {
        public CityCreateRepository(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext, IMapper mapper) :
            base(dbCommandContext, dbQueryContext, mapper)
        {
        }



    }
}
