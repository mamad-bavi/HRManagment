using Application.DTOs.Location.OrganizationDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListBySearchRequest : IRequest<IEnumerable<OrganizationGetListBySearchDto>>
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }
}
