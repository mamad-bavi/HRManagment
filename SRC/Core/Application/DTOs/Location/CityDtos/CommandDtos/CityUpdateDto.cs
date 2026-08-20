using Application.DTOParent.Location;
using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.CityDtos.CommandDtos
{
    public class CityUpdateDto : BaseDto, ICityDtoParent
    {
        public string Name { get ; set ; }
        public long ProvinceId { get ; set ; }
    }
}
