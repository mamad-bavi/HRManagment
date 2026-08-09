using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Person
{
    public class DocumentCategory : BaseEntity
    {
        public string Name { get; set; } // National ID, Passport, Contract, Degree, etc.
        public string Description { get; set; }
    }

}
