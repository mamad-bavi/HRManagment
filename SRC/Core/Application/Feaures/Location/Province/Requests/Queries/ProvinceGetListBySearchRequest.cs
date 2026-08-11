using Application.DTOs.Location.ProvinceDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Requests.Queries
{
    public class ProvinceGetListBySearchRequest : IRequest<IEnumerable<ProvinceGetListBySearchDto>>
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }
}
