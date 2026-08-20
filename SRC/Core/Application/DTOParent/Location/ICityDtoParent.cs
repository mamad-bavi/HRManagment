using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOParent.Location
{
    public interface ICityDtoParent
    {
        public string Name { get; set; }

        public long ProvinceId { get; set; }
    }
}
