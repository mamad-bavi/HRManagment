using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Application.Feaures.Location.City.Requests.Queries;
using Application.Utilities.AutoMapperGeneric;
using GenericRepositories.Filters;
using MediatR;

namespace Application.Feaures.Location.City.Handlers.Queries
{
    public class CityGetListRequestHandler : IRequestHandler<CityGetListRequest, GreadData<CityGetListDto>>
    {
        private readonly ICityCreateRepository cityRepository;

        public CityGetListRequestHandler(ICityCreateRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<GreadData<CityGetListDto>> Handle(CityGetListRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.City>()
            {
                Filter = request.GreadData.Filter,
                Page = request.GreadData.Page,
                PageSize = request.GreadData.PageSize,
                PageCount = request.GreadData.PageCount,
                Count = request.GreadData.Count,
            };
            
            var resualt = await cityRepository.GetListAsync(cancellationToken, gread);

            GreadData<CityGetListDto> greadData = new();
            greadData = request.GreadData;
            greadData.Data = resualt.Data.ToList().ConvertListObject<CityGetListDto, Domain.Entities.Location.City>();

            return greadData;
        }
    }
}
