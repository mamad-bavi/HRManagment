using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using AutoMapper;
using Domain.Entities.Location;
using Persistance.Context;
using Persistance.Repository.GenericRepository;

namespace Persistance.Repository.Location.CityRepository
{
    public class CityGetListRepository :
        RepositoryPublicAsyncDtoEFCore<City, CityGetListDto>,
        ICityGetListRepository
    {
        public CityGetListRepository(HRDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
