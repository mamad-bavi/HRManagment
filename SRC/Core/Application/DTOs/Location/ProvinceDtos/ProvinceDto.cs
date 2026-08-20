using Application.DTOs.Base;
using Application.DTOs.Location.CityDtos;
using Application.DTOs.Location.OrganizationDtos;
using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.ProvinceDtos
{
    public class ProvinceDto : BaseDto
    {
        public string Name { get; set; }
        [Ignore]
        public virtual ICollection<OrganizationDto> Organizations { get; set; }
        [Ignore]
        public virtual ICollection<CityDto> Cities { get; set; }
    }
}
