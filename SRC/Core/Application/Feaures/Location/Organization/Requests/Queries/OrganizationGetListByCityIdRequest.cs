using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using GenericRepositories.Filters;
using MediatR;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByCityIdRequest : IRequest<GreadData<OrganizationGetListByCityIdDto>>
    {
        public long CityId { get; set; }
        public GreadData<OrganizationGetListByCityIdDto> GreadData { get; set; }
    }
}
