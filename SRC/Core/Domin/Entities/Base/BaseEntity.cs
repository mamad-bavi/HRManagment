using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Base
{

public abstract class BaseEntity
{
    public long Id { get; set; }

    public long? CreateDate { get; set; }
    public long? CreateUserId { get; set; }
    public long? ModifyDate { get; set; }
    public long? ModifyUserId { get; set; }
    public long? DeletedUserId { get; set; }
    public bool? IsDeleted { get; set; }
}

}

