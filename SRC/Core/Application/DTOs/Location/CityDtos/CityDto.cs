using Application.DTOs.Base;
using Application.DTOs.Location.OrganizationDtos;
using Application.DTOs.Location.ProvinceDtos;
using AutoMapper.Configuration.Annotations;

namespace Application.DTOs.Location.CityDtos
{
    public class CityDto : BaseDto
    {
        public string Name { get; set; }

        public long ProvinceId { get; set; }
        public virtual ProvinceDto Province { get; set; }
        [Ignore]
        public virtual ICollection<OrganizationDto> Organizations { get; set; }
    }
}
