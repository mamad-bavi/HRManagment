using Application.DTOs.Location.ProvinceDtos.QueryDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Requests.Queries
{
    public class ProvinceGetByIdRequest : IRequest<ProvinceGetByIdDto>
    {
        public long Id { get; set; }
    }
}
