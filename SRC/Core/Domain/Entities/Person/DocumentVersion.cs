using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities.Person
{
    public class DocumentVersion : BaseEntity
    {

        public long EmployeeDocumentId { get; set; }
        [ForeignKey(nameof(EmployeeDocumentId))]
        public EmployeeDocument EmployeeDocument { get; set; }

        public int VersionNumber { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
