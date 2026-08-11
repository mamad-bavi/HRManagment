using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeContact : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات تماس اصلی
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string WorkEmail { get; set; }
        public string PersonalEmail { get; set; }

        // آدرس
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        // تماس اضطراری
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string EmergencyContactPhone { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
