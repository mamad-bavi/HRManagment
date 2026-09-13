using Application.Contracts.Location.CityContract;
using Application.DTOs.Location.CityDtos.QueryDtos;
using Application.Feaures.Location.City.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.City.Handlers.Commands
{
    public class CityDeleteCommandHandler : IRequestHandler<CityDeleteCommand, long>
    {
        private readonly ICityDeleteRepository cityRepository;
        private readonly ICityGetRepository cityGetRepository;

        public CityDeleteCommandHandler(ICityDeleteRepository cityRepository, ICityGetRepository cityGetRepository)
        {
            this.cityRepository = cityRepository;
            this.cityGetRepository = cityGetRepository;
        }
        public async Task<long> Handle(CityDeleteCommand request, CancellationToken cancellationToken)
        {
            var item = await cityGetRepository.GetByIdAsync(cancellationToken,request.Id);
            await cityRepository.DeleteAsync(item, cancellationToken);

            return item.Id;
        }
    }
}
