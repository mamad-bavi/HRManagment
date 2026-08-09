using Domin.Entities.Base;

namespace Domin.Entities.Location
{
    public class City:BaseEntity
    {
        public string Name { get; set; }

        public long ProvinceId { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }


    }
}