using Application.Contracts.Location.CityContract;
using AutoMapper;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.GenericCleanArchitecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityDeleteRepository :
        RepositoryDelete<City>,
        ICityDeleteRepository

    {
        public CityDeleteRepository(GenericCommandDbContext dbCommandContext,
            IMapper mapper) : base(dbCommandContext, mapper)
        {
        }
    }
}
