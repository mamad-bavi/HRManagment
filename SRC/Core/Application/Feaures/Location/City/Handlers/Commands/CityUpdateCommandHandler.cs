using Application.Contracts.Location;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Application.Feaures.Location.City.Requests.Commands;
using Application.Utilities.AutoMapperGeneric;
using Domain.Entities.Location;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Commands
{
    public class CityUpdateCommandHandler : IRequestHandler<CityUpdateCommand, long>
    {
        private readonly ICityRepository cityRepository;

        public CityUpdateCommandHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<long> Handle(CityUpdateCommand request, CancellationToken cancellationToken)
        {
            var item = request.CityUpdate
                .ConvertObject<Domain.Entities.Location.City, CityUpdateDto>();
            await cityRepository.UpdateAsync(item, cancellationToken);

            return item.Id;
        }
    }
}
