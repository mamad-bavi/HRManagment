using Application.DTOs.Location.CityDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Queries
{
    public class CityGetListRequest : IRequest<IEnumerable<CityGetListDto>>
    {

    }
}
