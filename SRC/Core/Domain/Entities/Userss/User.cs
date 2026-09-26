using Domain.Entities.Base;

namespace Domain.Entities.Userss
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Number { get; set; }
        public string Phone { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}