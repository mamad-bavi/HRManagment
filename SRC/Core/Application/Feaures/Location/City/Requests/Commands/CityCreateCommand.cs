using Application.DTOs.Location.CityDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Commands
{
    public class CityCreateCommand : IRequest<Unit>
    {
        public CityCreateDto CityCreate { get; set; }
    }
}
