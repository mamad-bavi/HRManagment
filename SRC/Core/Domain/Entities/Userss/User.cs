using Domain.Entities.Base;

namespace Domain.Entities.Userss
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}