using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class JobGrade : BaseEntity
    {

        // اطلاعات پایه
        public string Name { get; set; }            // مثل Grade A, Grade B, Senior Level
        public string Code { get; set; }            // کد یکتا برای گزارش‌گیری

        // سطح شغلی
        public int Level { get; set; }              // عدد سطح: 1,2,3,4...

        // بازه حقوق
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string Currency { get; set; }        // IRR, TRY, USD

        // توضیحات
        public string Description { get; set; }

        // ارتباط با سمت‌ها
        public ICollection<Position> Positions { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
