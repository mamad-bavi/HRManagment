using Application.Contracts.Location;
using Application.DTOs.Location.ProvinceDtos.QueryDtos;
using Application.Feaures.Location.Province.Requests.Queries;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Handlers.Queries
{
    public class ProvinceGetByIdRequestHandler : IRequestHandler<ProvinceGetByIdRequest, ProvinceGetByIdDto>
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceGetByIdRequestHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }

        public async Task<ProvinceGetByIdDto> Handle(ProvinceGetByIdRequest request, CancellationToken cancellationToken)
        {
            var resualt = await provinceRepository.GetByIdAsync(cancellationToken, request.Id);
            return resualt.ConvertObject<ProvinceGetByIdDto, Domain.Entities.Location.Province>();
        }
    }
}
