using Application.DTOs.Location.CityDtos.QueryDtos;
using GenericRepository.Filters;
using MediatR;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListRequest : IRequest<GreadData<CityGetListDto>>
    {
        public GreadData<CityGetListDto> GreadData { get; set; }
    }
}
