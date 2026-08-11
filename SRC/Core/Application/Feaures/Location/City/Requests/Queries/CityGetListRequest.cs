using Application.DTOs.Location.CityDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListRequest : IRequest<GreadData<CityGetListDto>>
    {
        public GreadData<CityGetListDto> GreadData { get; set; }
    }
}
