using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Requests.Commands
{
    public class ProvinceDeleteCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
