using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Requests.Commands
{
    public class CityDeleteCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
