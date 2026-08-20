using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListRequest : IRequest<GreadData<OrganizationGetListDto>>
    {
        public GreadData<OrganizationGetListDto> GreadData { get; set; }
    }
}
