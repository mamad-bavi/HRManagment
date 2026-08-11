using Application.Contracts.Location;
using Application.DTOs.Location.ProvinceDtos;
using Application.Feaures.Location.Province.Requests.Queries;
using Application.Filters;
using Application.Utilities.AutoMapperGeneric;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Feaures.Location.Province.Handlers.Queries
{
    public class ProvinceGetListRequestHandler : IRequestHandler<ProvinceGetListRequest, GreadData<ProvinceGetListDto>>
    {
        private readonly IProvinceRepository provinceRepository;

        public ProvinceGetListRequestHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        public async Task<GreadData<ProvinceGetListDto>> Handle(ProvinceGetListRequest request, CancellationToken cancellationToken)
        {
            var gread = new GreadData<Domain.Entities.Location.Province>()
            {
                Filter = request.GreadData.Filter,
                Page = request.GreadData.Page,
                PageSize = request.GreadData.PageSize,
                PageCount = request.GreadData.PageCount,
                Count = request.GreadData.Count,
            };
            var resualt = await provinceRepository.GetListAsync(cancellationToken, gread);
                

            GreadData<ProvinceGetListDto> greadData = new();
            greadData = request.GreadData;
            greadData.Data = resualt.Data.ToList().ConvertListObject<ProvinceGetListDto, Domain.Entities.Location.Province>();
            
            return greadData;
        }
    }
}
