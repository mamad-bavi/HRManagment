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
    public class OrganizationCreateCommandHandler :
        IRequestHandler<OrganizationCreateCommand, Unit>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationCreateCommandHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<Unit> Handle(OrganizationCreateCommand request, CancellationToken cancellationToken)
        {
            var item = request.OrganizationCreate
                .ConvertObject<Domain.Entities.Location.Organization, OrganizationCreateDto>();
            await organizationRepository.AddAsync(item, cancellationToken);

            return Unit.Task.Result;
        }
    }
}
