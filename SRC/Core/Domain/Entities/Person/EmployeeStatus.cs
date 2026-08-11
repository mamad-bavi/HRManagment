using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeStatus : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // وضعیت پرسنل
        public EmploymentStatusType Status { get; set; }

        // تاریخ اعمال وضعیت
        public DateTime EffectiveDate { get; set; }

        // توضیحات HR
        public string Description { get; set; }

        // آیا وضعیت فعلی است؟
        public bool IsCurrent { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }



    


}
