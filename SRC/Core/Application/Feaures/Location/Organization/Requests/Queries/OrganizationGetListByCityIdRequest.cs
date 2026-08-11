using Application.DTOs.Location.OrganizationDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetListByCityIdRequest : IRequest<IEnumerable<OrganizationGetListByCityIdDto>>
    {
        public long CityId { get; set; }
    }
}
