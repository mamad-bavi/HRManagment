using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class Employee : BaseEntity
    {

        // اطلاعات هویتی
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalId { get; set; }       // کد ملی
        public string BirthCertificateNo { get; set; } // شماره شناسنامه
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }           // Male / Female
        public string MaritalStatus { get; set; }    // Single / Married

        // اطلاعات سازمانی پایه
        public DateTime HireDate { get; set; }
        public string EmployeeCode { get; set; }     // کد پرسنلی

        // وضعیت پرسنل
        public EmployeeStatus Status { get; set; }   // Active / Inactive / Suspended

        // ارتباط با مدل‌های دیگر
        public ICollection<EmployeeContact> Contacts { get; set; }
        public ICollection<EmployeeJobInfo> JobInfos { get; set; }
        public ICollection<EmployeeDocument> Documents { get; set; }
        public ICollection<EmployeeBankInfo> BankInfos { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
