using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeEmergencyContact : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات فرد تماس اضطراری
        public string FullName { get; set; }
        public string Relation { get; set; } // Mother, Father, Spouse, Friend, etc.
        public string Mobile { get; set; }
        public string Phone { get; set; }

        // آدرس اختیاری
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        // آیا تماس اضطراری اصلی است؟
        public bool IsPrimary { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
