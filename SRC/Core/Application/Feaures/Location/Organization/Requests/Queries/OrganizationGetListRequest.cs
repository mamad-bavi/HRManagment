using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using GenericRepositories.Filters;
using MediatR;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListRequest : IRequest<GreadData<OrganizationGetListDto>>
    {
        public GreadData<OrganizationGetListDto> GreadData { get; set; }
    }
}
