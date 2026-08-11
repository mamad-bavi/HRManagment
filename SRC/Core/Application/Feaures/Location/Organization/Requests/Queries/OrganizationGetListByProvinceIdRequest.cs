using Application.DTOs.Location.OrganizationDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByProvinceIdRequest : IRequest<GreadData<OrganizationGetListByProvinceIdDto>>
    {
        public long ProvinceId { get; set; }
        public GreadData<OrganizationGetListByProvinceIdDto>? GreadData { get; set; }
    }
}
