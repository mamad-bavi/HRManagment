using Application.Contracts.Location;
using Application.DTOs.Location.CityDtos.CommandDtos;
using Application.Feaures.Location.City.Requests.Commands;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Commands
{
    public class CityCreateCommandHandler : IRequestHandler<CityCreateCommand, Unit>
    {
        private readonly ICityRepository cityRepository;

        public CityCreateCommandHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<Unit> Handle(CityCreateCommand request, CancellationToken cancellationToken)
        {
            var item = request.CityCreate
                .ConvertObject<Domain.Entities.Location.City, CityCreateDto>();
            await cityRepository.AddAsync(item, cancellationToken);

            return Unit.Task.Result;
        }
    }
}
