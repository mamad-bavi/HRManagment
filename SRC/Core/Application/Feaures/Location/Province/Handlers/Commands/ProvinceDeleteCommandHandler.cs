using Application.Contracts.Location;
using Application.Feaures.Location.Province.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Feaures.Location.Province.Handlers.Commands
{
    public class ProvinceDeleteCommandHandler : IRequestHandler<ProvinceDeleteCommand, long>
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceDeleteCommandHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        public async Task<long> Handle(ProvinceDeleteCommand request, CancellationToken cancellationToken)
        {
            var resualt = await provinceRepository.GetByIdAsync(cancellationToken, request.Id);
            await provinceRepository.DeleteAsync(resualt, cancellationToken);

            return resualt.Id;
        }
    }
}
