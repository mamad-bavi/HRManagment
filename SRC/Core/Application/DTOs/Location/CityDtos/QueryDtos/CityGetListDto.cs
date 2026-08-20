using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.CityDtos.QueryDtos
{
    public class CityGetListDto : BaseDto
    {
        public string Name { get; set; }
        public string ProvinceName { get; set; }
    }
}
