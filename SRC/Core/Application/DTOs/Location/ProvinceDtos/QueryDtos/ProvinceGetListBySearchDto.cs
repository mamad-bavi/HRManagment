using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.ProvinceDtos.QueryDtos
{
    public class ProvinceGetListBySearchDto : BaseDto
    {
        public string Name { get; set; }
    }
}
