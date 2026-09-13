using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Users
{
    public class UserRole : BaseEntity
    {
        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public long RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }

    }
}