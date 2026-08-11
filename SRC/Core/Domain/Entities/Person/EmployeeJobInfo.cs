using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeJobInfo : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات سازمانی
        public long DepartmentId { get; set; }
        public Department Department { get; set; }

        public long PositionId { get; set; }
        public Position Position { get; set; }

        public long JobGradeId { get; set; }
        public JobGrade JobGrade { get; set; }

        // نوع استخدام
        public EmploymentType EmploymentType { get; set; } // FullTime, PartTime, Contract, Internship

        // تاریخ‌های مهم
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // برای تاریخچه شغلی

        // وضعیت شغلی
        public bool IsCurrent { get; set; } // آیا رکورد فعلی است؟

        // اطلاعات مدیریتی
        public long? ManagerId { get; set; }
        public Employee Manager { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
