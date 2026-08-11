using Application.Contracts.Location;
using Application.DTOs.Location.CityDtos;
using Application.Feaures.Location.City.Requests.Queries;
using Application.Filters;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Queries
{
    public class CityGetListByProvinceIdRequestHandler : IRequestHandler<CityGetListByProvinceIdRequest, GreadData<CityGetListByProvinceIdDto>>
    {
        private readonly ICityRepository cityRepository;

        public CityGetListByProvinceIdRequestHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<GreadData<CityGetListByProvinceIdDto>> Handle(CityGetListByProvinceIdRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.City>()
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

            var resualt = await cityRepository.GetListAsync(cancellationToken, gread);

            GreadData<CityGetListByProvinceIdDto> greadData = new();
            greadData = request.GreadData;
            greadData.Data = resualt.Data.ToList().ConvertListObject<CityGetListByProvinceIdDto, Domain.Entities.Location.City>();

            return greadData;
        }
    }
}
