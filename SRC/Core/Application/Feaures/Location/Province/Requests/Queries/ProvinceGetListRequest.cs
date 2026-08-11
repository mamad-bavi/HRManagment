using Application.DTOs.Location.ProvinceDtos;
using Application.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Requests.Queries
{
    public class ProvinceGetListRequest : IRequest<GreadData<ProvinceGetListDto>>
    {
        public GreadData<ProvinceGetListDto> GreadData { get; set; }
    }
}
