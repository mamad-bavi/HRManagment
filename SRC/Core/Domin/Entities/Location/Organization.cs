using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Location
{
    public class Organization
    {
        public string Name { get; set; }

        public string OrganCode { get; set; }

        public long ProvinceId { get; set; }

        public long CityId { get; set; }

        public string Address { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public virtual Province Province { get; set; }

        public virtual City City { get; set; }




    }
}
