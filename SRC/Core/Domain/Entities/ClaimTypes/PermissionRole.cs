using Domain.Entities.Base;
using Domain.Entities.Userss;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.ClaimTypes
{
    public class PermissionRole : BaseEntity
    {
        public long RoleId { get; set; }

        public long PermissionId { get; set; }


        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(PermissionId))]
        public virtual Permission Permission { get; set; }

    }
}
