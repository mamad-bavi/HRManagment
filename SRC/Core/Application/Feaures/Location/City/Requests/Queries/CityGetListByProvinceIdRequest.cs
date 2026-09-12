using Application.DTOs.Location.CityDtos.QueryDtos;
using GenericRepository.Filters;
using MediatR;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListByProvinceIdRequest :IRequest<GreadData<CityGetListByProvinceIdDto>>
    {
        public long? ProvinceId { get; set; }
        public GreadData<CityGetListByProvinceIdDto> GreadData { get; set; }
    }
}
