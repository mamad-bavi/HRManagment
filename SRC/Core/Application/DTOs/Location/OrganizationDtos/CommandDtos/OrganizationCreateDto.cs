using Application.DTOParent.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.OrganizationDtos.CommandDtos
{
    public class OrganizationCreateDto : IOrganizationDtoParent
    {
        public string Name { get ; set ; }
        public string OrganCode { get ; set ; }
        public long ProvinceId { get ; set ; }
        public long CityId { get ; set ; }
        public string Address { get ; set ; }
    }
}
