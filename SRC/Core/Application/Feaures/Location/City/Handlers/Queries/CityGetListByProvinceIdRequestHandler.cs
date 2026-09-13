using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Application.Feaures.Location.City.Requests.Queries;
using Application.Utilities.AutoMapperGeneric;
using GenericRepository.Filters;
using MediatR;

namespace Application.Feaures.Location.City.Handlers.Queries
{
    public class CityGetListByProvinceIdRequestHandler : IRequestHandler<CityGetListByProvinceIdRequest, GreadData<CityGetListByProvinceIdDto>>
    {
        private readonly ICityGetRepository cityRepository;

        public CityGetListByProvinceIdRequestHandler(ICityGetRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<GreadData<CityGetListByProvinceIdDto>> Handle(CityGetListByProvinceIdRequest request, CancellationToken cancellationToken)
        {
            //var gread = new GreadData<Domain.Entities.Location.City>()
            //{
            //    Filter = request.GreadData.Filter,
            //    Page = request.GreadData.Page,
            //    PageSize = request.GreadData.PageSize,
            //    PageCount = request.GreadData.PageCount,
            //    Count = request.GreadData.Count,
            //};

            var resualt = await cityRepository.GetDtosAsync<CityGetListByProvinceIdDto>(cancellationToken, request.GreadData);

            //GreadData<CityGetListByProvinceIdDto> greadData = new();
            //greadData = request.GreadData;
            //greadData.Data = resualt.Data.ToList().ConvertListObject<CityGetListByProvinceIdDto, Domain.Entities.Location.City>();

            return resualt;
        }
    }
}
