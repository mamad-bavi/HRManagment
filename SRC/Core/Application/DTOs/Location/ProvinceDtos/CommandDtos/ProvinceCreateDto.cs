using Application.DTOParent.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.ProvinceDtos.CommandDtos
{
    public class ProvinceCreateDto : IProvinceDtoParent
    {
        public string Name { get ; set ; }
    }
}
