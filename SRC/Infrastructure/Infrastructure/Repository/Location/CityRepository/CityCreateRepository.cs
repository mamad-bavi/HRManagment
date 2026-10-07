using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.GenericCleanArchitecture;

namespace Infrastructure.Repository.Location.CityRepository
{
    public class CityCreateRepository :
        RepositoryAdd<City>,
        ICityCreateRepository

    {
       
        //public CityCreateRepository(GenericCommandDbContext dbCommandContext,
        //    GenericQueryDbContext dbQueryContext, IMapper mapper) : 
        //    base(dbCommandContext, dbQueryContext, mapper)
        //{
        //}
        public CityCreateRepository(GenericCommandDbContext dbCommandContext, 
            IMapper mapper) : base(dbCommandContext, mapper)
        {
        }
    }
}
