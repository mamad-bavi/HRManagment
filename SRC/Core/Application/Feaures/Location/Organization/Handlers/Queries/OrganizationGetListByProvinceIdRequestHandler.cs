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
    public class OrganizationGetListByProvinceIdRequestHandler :
        IRequestHandler<OrganizationGetListByProvinceIdRequest, GreadData<OrganizationGetListByProvinceIdDto>>
    {
        private readonly IOrganizationRepository organizationRepository;

        public OrganizationGetListByProvinceIdRequestHandler(IOrganizationRepository organizationRepository)
        {
            this.organizationRepository = organizationRepository;
        }
        public async Task<GreadData<OrganizationGetListByProvinceIdDto>> Handle(OrganizationGetListByProvinceIdRequest request, CancellationToken cancellationToken)
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
                Property = nameof(request.ProvinceId),
                Value = request.ProvinceId.ToString()
            });
            var resualt = await organizationRepository.GetListByProvinceId(cancellationToken, gread);
            
            GreadData<OrganizationGetListByProvinceIdDto> data = request.GreadData;
            data.Data = resualt.Data.ToList().ConvertListObject<OrganizationGetListByProvinceIdDto, Domain.Entities.Location.Organization>();

            return data;
        }
    }
}
