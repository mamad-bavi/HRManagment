using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Person
{
    public class DocumentVersion : BaseEntity
    {

        public long EmployeeDocumentId { get; set; }
        public EmployeeDocument EmployeeDocument { get; set; }

        public int VersionNumber { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
