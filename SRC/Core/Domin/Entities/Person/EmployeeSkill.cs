using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Person
{
    public class EmployeeSkill : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات مهارت
        public string SkillName { get; set; }          // مثل C#, Leadership, Excel
        public SkillType SkillType { get; set; }       // Technical, SoftSkill, Language

        // سطح مهارت
        public SkillLevel Level { get; set; }          // Beginner, Intermediate, Expert

        // تاریخ‌های مهم
        public DateTime AcquiredDate { get; set; }     // تاریخ کسب مهارت
        public DateTime? LastUsedDate { get; set; }    // آخرین زمان استفاده

        // وضعیت تأیید
        public SkillVerificationStatus VerificationStatus { get; set; }
        public long? VerifiedByUserId { get; set; }    // مدیر یا HR

        // توضیحات
        public string Description { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }


    


}
