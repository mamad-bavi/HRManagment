using Application.DTOs.Location.CityDtos.QueryDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListByProvinceIdRequest :IRequest<GreadData<CityGetListByProvinceIdDto>>
    {
        public long? ProvinceId { get; set; }
        public GreadData<CityGetListByProvinceIdDto> GreadData { get; set; }
    }
}
