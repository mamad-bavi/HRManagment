using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Queries
{
    public class OrganizationGetByIdRequest : IRequest<OrganizationGetByIdDto>
    {
        public long Id { get; set; }
    }
}
