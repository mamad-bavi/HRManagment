using Domin.Entities.Base;
using Domin.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.People
{
    public class JobPosition : BaseEntity
    {
        public string Name { get; set; }
        public long Pid { get; set; }
        public long OrganizationId { get; set; }


        public virtual Organization Organization { get; set; }
        public virtual JobPosition ParentPosition { get; set; }
        public virtual ICollection<JobPositionPerson> JobPositionPeople { get; set; }

    }
}
