using Application.DTOParent.Location;
using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.OrganizationDtos.CommandDtos
{
    public class OrganizationUpdateDto : BaseDto, IOrganizationDtoParent
    {
        public string Name { get ; set ; }
        public string OrganCode { get ; set ; }
        public long ProvinceId { get ; set ; }
        public long CityId { get ; set ; }
        public string Address { get ; set ; }
    }
}
