using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
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
        private readonly ICityGetRepository cityRepository;

        public CityGetByIdRequestHandler(ICityGetRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<CityGetByIdDto> Handle(CityGetByIdRequest request, CancellationToken cancellationToken)
        {
            var resualt = await cityRepository.GetDtoByIdAsync<CityGetByIdDto>(cancellationToken, request.Id);
            return resualt;
        }
    }
}
