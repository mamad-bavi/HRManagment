using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeExperience : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات شرکت قبلی
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public string EmploymentType { get; set; } // FullTime, PartTime, Contract, Internship

        // تاریخ‌ها
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // وظایف و مسئولیت‌ها
        public string Responsibilities { get; set; } // متن آزاد

        // دستاوردها
        public string Achievements { get; set; } // متن آزاد

        // مهارت‌های کسب‌شده
        public string SkillsGained { get; set; } // مثل C#, SQL, Leadership

        // اطلاعات حقوقی (اختیاری)
        public decimal? LastSalary { get; set; }
        public string Currency { get; set; } // IRR, TRY, USD

        // توضیحات HR
        public string Description { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
