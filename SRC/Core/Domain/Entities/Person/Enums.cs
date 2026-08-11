using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Person
{
    public enum SkillVerificationStatus
    {
        Pending,        // در انتظار تأیید
        Verified,       // تأیید شده
        Rejected        // رد شده
    }

    public enum SkillLevel
    {
        Beginner,
        Intermediate,
        Expert
    }

    public enum SkillType
    {
        Technical,      // مهارت‌های فنی مثل C#, SQL, Networking
        SoftSkill,      // مهارت‌های نرم مثل Communication, Leadership
        Language        // زبان‌ها مثل English, Turkish, German
    }

    public enum EmploymentStatusType
    {
        Active,         // فعال
        Inactive,       // غیرفعال
        Suspended,      // تعلیق
        OnLeave,        // مرخصی بلندمدت
        Probation,      // دوره آزمایشی
        Terminated,     // پایان همکاری / اخراج
        Retired,        // بازنشسته
        Transferred,    // انتقال به شعبه دیگر
        Deceased        // فوت شده
    }

    public enum DocumentStatus
    {
        Pending,    // در انتظار بررسی
        Approved,   // تأیید شده
        Rejected    // رد شده
    }

    public enum EmploymentType
    {
        FullTime,
        PartTime,
        Contract,
        Internship,
        Temporary
    }

    public enum EducationType
    {
        Formal,         // تحصیلات رسمی دانشگاهی
        Certificate,    // گواهینامه معتبر مثل PMP، CCNA
        Course          // دوره‌های کوتاه‌مدت مثل ICDL، Excel
    }

    public enum EducationVerificationStatus
    {
        Pending,
        Verified,
        Rejected
    }



}
