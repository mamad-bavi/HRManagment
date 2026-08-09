using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Location
{
    public class Province:BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }

    }
}
