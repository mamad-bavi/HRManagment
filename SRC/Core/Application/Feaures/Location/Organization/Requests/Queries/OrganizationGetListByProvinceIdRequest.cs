using Application.DTOs.Location.OrganizationDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByProvinceIdRequest : IRequest<IEnumerable<OrganizationGetListByProvinceIdDto>>
    {
        public long ProvinceId { get; set; }
    }
}
