using Application.DTOs.Base;
using Application.DTOs.Location.ProvinceDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.CityDtos.QueryDtos
{
    public class CityGetByIdDto : BaseDto
    {
        public string Name { get; set; }
        public string ProvinceName { get; set; }
        public long ProvinceId { get; set; }
        public virtual ProvinceDto Province { get; set; }
    }
}
