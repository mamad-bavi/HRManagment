using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.Base
{

    public interface IBaseEntity
    {
    }

    public abstract class BaseEntity<TKey,TDateProperty> : IBaseEntity
    {
        public TKey Id { get; set; }

        public TDateProperty? CreateDate { get; set; }
        public TKey? CreateUserId { get; set; }
        public TDateProperty? ModifyDate { get; set; }
        public TKey? ModifyUserId { get; set; }
        public TDateProperty DeletedDate { get; set; }
        public TKey? DeletedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }

    public abstract class BaseEntity<TDateProperty> : BaseEntity<long, TDateProperty>
    {
    }

    public abstract class BaseEntity:BaseEntity<long>
    {
    }

}

