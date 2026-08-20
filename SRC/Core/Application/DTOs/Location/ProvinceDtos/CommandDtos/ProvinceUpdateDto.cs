using Application.DTOParent.Location;
using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.ProvinceDtos.CommandDtos
{
    public class ProvinceUpdateDto : BaseDto, IProvinceDtoParent
    {
        public string Name { get ; set ; }
    }
}
