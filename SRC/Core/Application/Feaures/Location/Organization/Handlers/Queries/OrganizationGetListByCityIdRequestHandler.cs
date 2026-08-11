using Application.Contracts.Location;
using Application.DTOs.Location.OrganizationDtos;
using Application.Feaures.Location.Organization.Requests.Queries;
using Application.Filters;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Organization.Handlers.Queries
{
    public class OrganizationGetListByCityIdRequestHandler :
        IRequestHandler<OrganizationGetListByCityIdRequest, GreadData<OrganizationGetListByCityIdDto>>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationGetListByCityIdRequestHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<GreadData<OrganizationGetListByCityIdDto>> Handle(OrganizationGetListByCityIdRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.Organization>()
            {
                Filter = request.GreadData.Filter,
                Page = request.GreadData.Page,
                PageSize = request.GreadData.PageSize,
                PageCount = request.GreadData.PageCount,
                Count = request.GreadData.Count,
            };
            gread.Filter.Add(new Filter
            {
                Property = nameof(request.CityId),
                Value = request.CityId.ToString()
            });
            var resualt = await organizationRepository.GetListByProvinceId(cancellationToken, gread);

            GreadData<OrganizationGetListByCityIdDto> data = request.GreadData;
            data.Data = resualt.Data.ToList().ConvertListObject<OrganizationGetListByCityIdDto, Domain.Entities.Location.Organization>();

            return data;
        }

    }
    
}
