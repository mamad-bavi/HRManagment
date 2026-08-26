using Application.Contracts.GenericContract;
using Application.Filters;
using Application.Utilities.ApplicationSettings;
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
        private readonly DbConnectionSetting setting;

        public RepositoryPublicAsyncDapper(IConfiguration configuration, DbConnectionSetting setting)
        {
            this.configuration = configuration;
            this.setting = setting;
        }

        public async Task<TEntity> GetByIdQueryAsync(long Id)

        {
            var tableName = typeof(TEntity).Name;

            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 0 and Id = @Id";

            using (var connection = new SqlConnection(setting.QueryConnectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<TEntity>(sql, new { Id = Id });
            }
        }

        public async Task<GreadData<TEntity>> GetByRangIdQuerAsync(List<long> ids)
        {
            var tableName = typeof(TEntity).Name;

            const string sqlTemplate = """
        SELECT *
        FROM [{0}]
        WHERE IsDeleted = 0
        AND Id IN @Ids
        """;

            var sql = string.Format(sqlTemplate, tableName);

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            var result = await connection
                .QueryAsync<TEntity>(sql, new { Ids = ids });

            return new GreadData<TEntity>
            {
                Data = result
            };
        }

        public virtual async Task<GreadData<TEntity>> GetByQueryAsync(CancellationToken cancellationToken, GreadData<TEntity> data)
        {
            var tableName = typeof(TEntity).Name;
            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted <> 1";
            foreach (var filter in data.Filter)
            {
                sql += $" And {filter.Property} Like N'%{filter.Value}%' ";
            }


            using (var connection = new SqlConnection(setting.QueryConnectionString))
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

            foreach (var filter in data.Filter)
            {
                sql += $" And {filter.Property} Like N'%{filter.Value}%'";
            }


            using (var connection = new SqlConnection(setting.QueryConnectionString))
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

            var sql = $"SELECT * FROM [{tableName}] WHERE IsDeleted = 1 and Id = @Id";

            using (var connection = new SqlConnection(setting.QueryConnectionString))
            {
                GreadData<TEntity> data = new();
                data.Entity = await connection.QueryFirstOrDefaultAsync<TEntity>(sql, new { Id = Id });
                return data;
            }
        }

        public async Task<bool> AddByDapperAsync(TEntity entity)
        {
            var properties = typeof(TEntity)
        .GetProperties()
        .Where(p => p.Name != "Id")
        .ToList();

            var columns = string.Join(", ", properties.Select(p => p.Name));
            var parameters = string.Join(", ", properties.Select(p => "@" + p.Name));

            var query = $"""
        INSERT INTO {typeof(TEntity).Name}
        ({columns})
        VALUES ({parameters})
        """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            await connection.ExecuteAsync(query, entity);

            return true;
        }

        public async Task<bool> UpdateByDapperAsync(TEntity entity)
        {
            var properties = typeof(TEntity)
       .GetProperties()
       .Where(p => p.Name != "Id")
       .ToList();

            var setClause = string.Join(
                ", ",
                properties.Select(p => $"{p.Name} = @{p.Name}")
            );

            var query = $"""
        UPDATE {typeof(TEntity).Name}
        SET {setClause}
        WHERE Id = @Id
        """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            var affectedRows = await connection.ExecuteAsync(query, entity);

            return affectedRows > 0;
        }
    }
}
