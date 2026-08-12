using Application.Contracts.Location;
using Application.Feaures.Location.City.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Commands
{
    public class CityDeleteCommandHandler : IRequestHandler<CityDeleteCommand, long>
    {
        private readonly ICityRepository cityRepository;

        public CityDeleteCommandHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<long> Handle(CityDeleteCommand request, CancellationToken cancellationToken)
        {
            var item = await cityRepository.GetByIdAsync(cancellationToken, cancellationToken);
            await cityRepository.DeleteAsync(item, cancellationToken);

            return item.Id;
        }
    }
}
