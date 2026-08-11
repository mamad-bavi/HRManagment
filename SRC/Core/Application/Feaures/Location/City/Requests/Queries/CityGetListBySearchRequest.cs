using Application.DTOs.Location.CityDtos;
using MediatR;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListBySearchRequest : IRequest<IEnumerable<CityGetListBySearchDto>>
    {
        public string? Property { get; set; }
        public string? Value { get; set; }
    }
}
