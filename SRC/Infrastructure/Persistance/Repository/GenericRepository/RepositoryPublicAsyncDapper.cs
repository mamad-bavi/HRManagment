using Application.Contracts.GenericContract;
using Application.Filters;
using Dapper;
using Domain.Entities.Base;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Repository.GenericRepository
{
    public class RepositoryPublicAsyncDapper<TEntity> :
         IRepositoryPublicAsyncDapper<TEntity> where TEntity : class, IBaseEntity
    {

        private readonly IConfiguration configuration;

        public RepositoryPublicAsyncDapper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<TEntity> GetByIdQueryAsync(long Id)

        {
            var tableName = typeof(TEntity).Name;
            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 0 and Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<TEntity>(sql, new { Id = Id });
            }
        }

        public async Task<GreadData<TEntity>> GetByRangIdQuerAsync(List<long> Ids)
        {
            var tableName = typeof(TEntity).Name;
            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 0 and Id in (";

            foreach (var id in Ids)
                sql += $"{id},";
            sql += "0)";

            using (var connection = new SqlConnection(connectionString))
            {
                GreadData<TEntity> greadData = new GreadData<TEntity>();

                greadData.Data = await connection.QueryFirstOrDefaultAsync<IEnumerable<TEntity>>(sql);

                return greadData;
            }
        }

        public virtual async Task<GreadData<TEntity>> GetByQueryAsync(CancellationToken cancellationToken, GreadData<TEntity> data)
        {
            var tableName = typeof(TEntity).Name;
            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted <> 1";
            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            //if (!string.IsNullOrWhiteSpace(where))
            //    sql += " AND " + where;
            foreach (var filter in data.Filter)
            {
                sql += $" And {filter.Property} Like N'%{filter.Value}%' ";
            }


            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                data.Data = (await connection.QueryAsync<TEntity>(sql, cancellationToken))
                    .Skip((data.Page - 1) * data.PageSize)
                    .Take(data.PageSize)
                    .ToList();
                data.PageCount = data.PageSize;
                data.Count = data.Data.Count();
                return data;
            }
        }

        public virtual async Task<GreadData<TEntity>> GetByQueryDeletedItemsAsync(CancellationToken cancellationToken, GreadData<TEntity> data)
        {
            var tableName = typeof(TEntity).Name;
            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 1";

            //if (!string.IsNullOrWhiteSpace(where))
            //    sql += " AND " + where;

            foreach (var filter in data.Filter)
            {
                sql += $" And {filter.Property} Like N'%{filter.Value}%'";
            }


            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                data.Data = (await connection.QueryAsync<TEntity>(sql, cancellationToken))
                       .Skip((data.Page - 1) * data.PageSize)
                       .Take(data.PageSize)
                       .ToList();
                data.PageCount = data.PageSize;
                data.Count = data.Data.Count();
                return data;
            }
        }

        public async Task<GreadData<TEntity>> GetByIdDeletedItemQueryAsync(long Id)
        {
            var tableName = typeof(TEntity).Name;
            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 1 and Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                GreadData<TEntity> data = new();
                data.Entity = await connection.QueryFirstOrDefaultAsync<TEntity>(sql, new { Id = Id });
                return data;
            }
        }

    }
}
