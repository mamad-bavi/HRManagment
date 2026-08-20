using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOParent.Location
{
    public interface IOrganizationDtoParent
    {
        public string Name { get; set; }

        public string OrganCode { get; set; }

        public long ProvinceId { get; set; }

        public long CityId { get; set; }

        public string Address { get; set; }
    }
}
