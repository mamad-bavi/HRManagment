using Application.Contracts.Location;
using Application.Feaures.Location.Organization.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Handlers.Commands
{
    public class OrganizationDeleteCommandHandler :
        IRequestHandler<OrganizationDeleteCommand, long>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationDeleteCommandHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<long> Handle(OrganizationDeleteCommand request, CancellationToken cancellationToken)
        {
            var item = await organizationRepository.GetByIdAsync(cancellationToken, request.Id);
            await organizationRepository.DeleteAsync(item, cancellationToken);

            return item.Id;
        }
    }
}
