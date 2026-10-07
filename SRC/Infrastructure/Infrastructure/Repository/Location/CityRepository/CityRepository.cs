using Application.Contracts.Location.CityContract;
using Domain.Entities.Location;
using GenericRepository.Context;
using GenericRepository.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Location.CityRepository
{
    public class CityRepository :
        RepositoryPublicAsyncEFCore<City>,
        ICityRepository
    {
        public CityRepository(GenericCommandDbContext dbCommandContext,
            GenericQueryDbContext dbQueryContext) :
            base(dbCommandContext, dbQueryContext)
        {
        }
    }
}
