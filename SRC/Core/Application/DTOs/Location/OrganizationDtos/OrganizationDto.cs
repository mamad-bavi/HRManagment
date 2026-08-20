using Application.DTOs.Base;
using Application.DTOs.Location.CityDtos;
using Application.DTOs.Location.ProvinceDtos;

namespace Application.DTOs.Location.OrganizationDtos
{
    public class OrganizationDto : BaseDto
    {
        public string Name { get; set; }
        public string OrganCode { get; set; }
        public long ProvinceId { get; set; }
        public long CityId { get; set; }
        public string Address { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public virtual ProvinceDto Province { get; set; }
        public virtual CityDto City { get; set; }


    }
}
