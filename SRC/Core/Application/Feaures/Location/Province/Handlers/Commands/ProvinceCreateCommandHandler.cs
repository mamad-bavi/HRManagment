using Application.Contracts.Location;
using Application.DTOs.Location.ProvinceDtos;
using Application.Feaures.Location.Province.Requests.Commands;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Handlers.Commands
{
    public class ProvinceCreateCommandHandler : IRequestHandler<ProvinceCreateCommand, Unit>
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceCreateCommandHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        public async Task<Unit> Handle(ProvinceCreateCommand request, CancellationToken cancellationToken)
        {
            var item = request.ProvinceCreate
                .ConvertObject<Domain.Entities.Location.Province, ProvinceCreateDto>();
            await provinceRepository.AddAsync(item,cancellationToken);

            return Unit.Task.Result;
        }
    }
}
