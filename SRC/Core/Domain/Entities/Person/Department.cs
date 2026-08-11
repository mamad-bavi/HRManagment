using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public class Department : BaseEntity
    {
        // نام واحد
        public string Name { get; set; }
        public string Code { get; set; } // کد واحد برای گزارش‌گیری

        // ساختار درختی
        public long? ParentDepartmentId { get; set; }
        public Department ParentDepartment { get; set; }
        public ICollection<Department> SubDepartments { get; set; }

        // مدیر واحد
        public long? ManagerId { get; set; }
        public Employee Manager { get; set; }

        // اطلاعات مالی
        public string CostCenterCode { get; set; }

        // توضیحات
        public string Description { get; set; }

        // متادیتا
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

}
