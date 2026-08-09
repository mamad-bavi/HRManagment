using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.People
{
    public class JobPositionPerson:BaseEntity
    {
        public long JobPositionId { get; set; }
        public virtual JobPosition JobPosition { get; set; }

        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

    }
}
