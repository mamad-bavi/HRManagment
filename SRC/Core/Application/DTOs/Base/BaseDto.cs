using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Base
{
    public abstract class BaseDto<TKey>
    {
        public TKey Id { get; set; }

    }

    public abstract class BaseDto : BaseDto<long>
    {

    }




}
