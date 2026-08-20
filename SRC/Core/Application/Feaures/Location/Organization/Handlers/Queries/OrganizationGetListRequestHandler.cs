using Application.Contracts.Location;
using Application.DTOs.Location.OrganizationDtos.QueryDtos;
using Application.DTOs.Location.ProvinceDtos;
using Application.Feaures.Location.Organization.Requests.Queries;
using Application.Filters;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Handlers.Queries
{
    public class OrganizationGetListRequestHandler : IRequestHandler<OrganizationGetListRequest, GreadData<OrganizationGetListDto>>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationGetListRequestHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<GreadData<OrganizationGetListDto>> Handle(OrganizationGetListRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.Organization>()
            {
                Filter = request.GreadData.Filter,
                Page = request.GreadData.Page,
                PageSize = request.GreadData.PageSize,
                PageCount = request.GreadData.PageCount,
                Count = request.GreadData.Count,
            };

            var resualt = await organizationRepository.GetListAsync(cancellationToken,gread);

            GreadData<OrganizationGetListDto> greadData = new();
            greadData = request.GreadData;
            greadData.Data = resualt.Data.ToList().ConvertListObject<OrganizationGetListDto, Domain.Entities.Location.Organization>();

            return greadData;
        }
    }
}
