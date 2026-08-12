using Application.Contracts.Location;
using Application.DTOs.Location.OrganizationDtos;
using Application.Feaures.Location.Organization.Requests.Commands;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Handlers.Commands
{
    public class OrganizationUpdateCommandHandler : IRequestHandler<OrganizationUpdateCommand, long>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationUpdateCommandHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<long> Handle(OrganizationUpdateCommand request, CancellationToken cancellationToken)
        {
            var item = request.OrganizationUpdate
                .ConvertObject<Domain.Entities.Location.Organization, OrganizationUpdateDto>();
            await organizationRepository.UpdateAsync(item, cancellationToken);

            return item.Id;
        }
    }
}
