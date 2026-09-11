using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using GenericRepository.Filters;
using MediatR;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByProvinceIdRequest : IRequest<GreadData<OrganizationGetListByProvinceIdDto>>
    {
        public long ProvinceId { get; set; }
        public GreadData<OrganizationGetListByProvinceIdDto>? GreadData { get; set; }
    }
}
