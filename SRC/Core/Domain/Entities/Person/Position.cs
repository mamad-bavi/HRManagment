using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class Position : BaseEntity
    {
        // نام سمت
        public string Title { get; set; }             // مثل Senior Developer, HR Manager
        public string Code { get; set; }              // کد سمت برای گزارش‌گیری

        // ارتباط با واحد سازمانی
        public long DepartmentId { get; set; }
        public Department Department { get; set; }

        // درجه شغلی
        public long JobGradeId { get; set; }
        public JobGrade JobGrade { get; set; }

        // شرح وظایف
        public string Responsibilities { get; set; }  // متن آزاد

        // مهارت‌های موردنیاز
        public string RequiredSkills { get; set; }    // مثل C#, Leadership, Excel

        // وضعیت سمت
        public bool IsActive { get; set; }

        // توضیحات
        public string Description { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
