using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeEducation : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات تحصیلی
        public string Degree { get; set; }              // Bachelor, Master, Diploma, etc.
        public string FieldOfStudy { get; set; }        // Computer Science, Accounting, etc.
        public string InstitutionName { get; set; }     // دانشگاه یا موسسه
        public EducationType EducationType { get; set; } // Formal, Certificate, Course

        // تاریخ‌ها
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // وضعیت تأیید
        public EducationVerificationStatus VerificationStatus { get; set; }
        public long? VerifiedByUserId { get; set; }

        // فایل مدرک (اختیاری)
        public string CertificateFilePath { get; set; }

        // توضیحات
        public string Description { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
