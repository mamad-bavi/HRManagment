using Domin.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Person
{
    public class EmployeeBankInfo : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // اطلاعات بانکی
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
        public string IBAN { get; set; } // شماره شبا

        // آیا حساب اصلی برای پرداخت حقوق است؟
        public bool IsPrimary { get; set; }

        // تاریخ‌های مهم
        public DateTime EffectiveDate { get; set; } // تاریخ فعال شدن حساب
        public DateTime? EndDate { get; set; }      // برای تاریخچه حساب‌ها

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
