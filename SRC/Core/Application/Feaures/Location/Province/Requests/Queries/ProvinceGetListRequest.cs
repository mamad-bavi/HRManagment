using Application.DTOs.Location.ProvinceDtos.QueryDtos;
using GenericRepository.Filters;
using MediatR;

namespace Application.Feaures.Location.Province.Requests.Queries
{
    public class ProvinceGetListRequest : IRequest<GreadData<ProvinceGetListDto>>
    {
        public GreadData<ProvinceGetListDto> GreadData { get; set; }
    }
}
