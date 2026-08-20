using Application.Contracts.Location;
using Application.DTOs.Location.ProvinceDtos.CommandDtos;
using Application.Feaures.Location.Province.Requests.Commands;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Handlers.Commands
{
    public class ProvinceUpdateComandHandler : IRequestHandler<ProvinceUpdateComand, long>
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceUpdateComandHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        public async Task<long> Handle(ProvinceUpdateComand request, CancellationToken cancellationToken)
        {
            var item = request.ProvinceUpdate
                .ConvertObject<Domain.Entities.Location.Province, ProvinceUpdateDto>();
            await provinceRepository.UpdateAsync(item,cancellationToken);

            return item.Id;
        }
    }
}
