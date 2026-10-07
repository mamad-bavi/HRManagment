using Domain.Entities.Base;
using System.Reflection;

namespace Domain.Entities.Userss
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalCode { get; set; }

        public Gender Gender { get; set; }

        public string SecurityStamp { get; set; } = Guid.NewGuid().ToString();

        public DateTimeOffset LastLoginDate { get; set; } = DateTime.Now;


        public virtual ICollection<UserRole> UserRoles { get; set; }
    }

}