using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Requests.Commands
{
    public class OrganizationDeleteCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
