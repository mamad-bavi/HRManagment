using Application.DTOs.Location.CityDtos.QueryDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetByIdRequest : IRequest<CityGetByIdDto>
    {
        public long Id { get; set; }
    }
}
