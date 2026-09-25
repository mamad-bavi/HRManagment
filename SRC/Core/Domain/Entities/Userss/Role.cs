using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Userss
{
    public class Role 
    {
        public string RoleCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
