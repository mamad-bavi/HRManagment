using Application.DTOs.Location.OrganizationDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Commands
{
    public class OrganizationUpdateCommand : IRequest<long>
    {
        public OrganizationUpdateDto OrganizationUpdate { get; set; }
    }
}
