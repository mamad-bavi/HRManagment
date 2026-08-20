using Application.DTOParent.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.CityDtos.CommandDtos
{
    public class CityCreateDto : ICityDtoParent
    {
        public string Name { get ; set ; }
        public long ProvinceId { get ; set ; }
    }
}
