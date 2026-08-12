using Application.Contracts.Location;
using Application.DTOs.Location.CityDtos;
using Application.Feaures.Location.City.Requests.Queries;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Queries
{
    public class CityGetByIdRequestHandler : IRequestHandler<CityGetByIdRequest, CityGetByIdDto>
    {
        private readonly ICityRepository cityRepository;

        public CityGetByIdRequestHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<CityGetByIdDto> Handle(CityGetByIdRequest request, CancellationToken cancellationToken)
        {
            var resualt = await cityRepository.GetByIdAsync(cancellationToken, request.Id);
            return resualt.ConvertObject<CityGetByIdDto, Domain.Entities.Location.City>();
        }
    }
}
