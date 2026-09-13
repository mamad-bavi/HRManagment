using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.CommandDtos;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.Generic;
using GenericRepository.Repositories.GenericCleanArchitecture;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityUpdateRepository :
        RepositoryUpdate<City>,
        ICityUpdateRepository
    {
        public CityUpdateRepository(GenericCommandDbContext dbCommandContext, IMapper mapper) : base(dbCommandContext, mapper)
        {
        }
    }
}
