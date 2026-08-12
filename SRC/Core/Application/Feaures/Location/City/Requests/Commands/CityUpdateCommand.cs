using Application.DTOs.Location.CityDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Commands
{
    public class CityUpdateCommand : IRequest<long>
    {
        public CityUpdateDto CityUpdate { get; set; }
    }
}
