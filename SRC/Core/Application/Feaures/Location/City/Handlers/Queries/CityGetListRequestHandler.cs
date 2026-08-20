using Application.Contracts.Location;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Application.DTOs.Location.ProvinceDtos;
using Application.Feaures.Location.City.Requests.Queries;
using Application.Filters;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Queries
{
    public class CityGetListRequestHandler : IRequestHandler<CityGetListRequest, GreadData<CityGetListDto>>
    {
        private readonly ICityRepository cityRepository;

        public CityGetListRequestHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<GreadData<CityGetListDto>> Handle(CityGetListRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.City>()
            {
                Filter = request.GreadData.Filter,
                Page = request.GreadData.Page,
                PageSize = request.GreadData.PageSize,
                PageCount = request.GreadData.PageCount,
                Count = request.GreadData.Count,
            };
            
            var resualt = await cityRepository.GetListAsync(cancellationToken, gread);

            GreadData<CityGetListDto> greadData = new();
            greadData = request.GreadData;
            greadData.Data = resualt.Data.ToList().ConvertListObject<CityGetListDto, Domain.Entities.Location.City>();

            return greadData;
        }
    }
}
