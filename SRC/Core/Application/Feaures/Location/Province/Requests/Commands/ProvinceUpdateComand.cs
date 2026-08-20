using Application.DTOs.Location.ProvinceDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Requests.Commands
{
    public class ProvinceUpdateComand : IRequest<long>
    {
        public ProvinceUpdateDto ProvinceUpdate { get; set; }
    }
}
