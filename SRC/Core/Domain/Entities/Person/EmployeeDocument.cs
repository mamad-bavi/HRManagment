using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class EmployeeDocument : BaseEntity
    {

        // ارتباط با Employee
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // نوع سند
        public long DocumentCategoryId { get; set; }
        public DocumentCategory DocumentCategory { get; set; }

        // اطلاعات سند
        public string FileName { get; set; }
        public string FilePath { get; set; } // مسیر ذخیره‌سازی (Local, Cloud, S3, MinIO)
        public string FileType { get; set; } // pdf, jpg, png, docx

        // تاریخ‌های مهم
        public DateTime IssueDate { get; set; }       // تاریخ صدور
        public DateTime? ExpiryDate { get; set; }     // تاریخ انقضا (برای کارت ملی، پاسپورت، گواهینامه)

        // وضعیت سند
        public DocumentStatus Status { get; set; }    // Pending, Approved, Rejected

        // توضیحات HR
        public string Description { get; set; }

        // نسخه‌بندی
        public ICollection<DocumentVersion> Versions { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }


  

}
