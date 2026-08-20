using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Location.OrganizationDtos.QueryDtos
{
    public class OrganizationGetListBySearchDto : BaseDto
    {
        public string Name { get; set; }
        public string OrganCode { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
    }
}
