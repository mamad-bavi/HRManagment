using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByCityIdRequest : IRequest<GreadData<OrganizationGetListByCityIdDto>>
    {
        public long CityId { get; set; }
        public GreadData<OrganizationGetListByCityIdDto> GreadData { get; set; }
    }
}
