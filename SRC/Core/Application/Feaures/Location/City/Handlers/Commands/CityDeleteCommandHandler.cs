using Application.Contracts.Location.CityContract;
using Application.Feaures.Location.City.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Commands
{
    public class CityDeleteCommandHandler : IRequestHandler<CityDeleteCommand, long>
    {
        private readonly ICityCreateRepository cityRepository;

        public CityDeleteCommandHandler(ICityCreateRepository cityRepository)
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
