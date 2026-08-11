using Application.Contracts.GenericContract;
using Application.Filters;
using Domain.Entities.Location;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Location
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        Task<GreadData<Organization>> GetListByProvinceId(CancellationToken cancellationToken, GreadData<Organization> data);
        Task<GreadData<Organization>> GetListByCityId(CancellationToken cancellationToken, long cityId);
    }
}
