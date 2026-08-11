using Application.Contracts.Location;
using Application.DTOs.Location.OrganizationDtos;
using Application.Feaures.Location.Organization.Requests.Queries;
using Application.Utilities.AutoMapperGeneric;
using MediatR;

namespace Application.Feaures.Location.Organization.Handlers.Queries
{
    public class OrganizationGetByIdRequestHandler : IRequestHandler<OrganizationGetByIdRequest, OrganizationGetByIdDto>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationGetByIdRequestHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<OrganizationGetByIdDto> Handle(OrganizationGetByIdRequest request, CancellationToken cancellationToken)
        {
            var resualt = await organizationRepository.GetByIdAsync(cancellationToken, request.Id);
            return resualt.ConvertObject<OrganizationGetByIdDto, Domain.Entities.Location.Organization>();
        }
    }
}
