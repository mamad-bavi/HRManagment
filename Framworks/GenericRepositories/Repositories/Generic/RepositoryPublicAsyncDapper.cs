using Dapper;
using GenericRepositories.Context;
using GenericRepositories.Contracts.Generic;
using GenericRepositories.Filters;
using GenericRepositories.ParentEntities;
using GenericRepositories.Settings;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;

namespace GenericRepositories.Repositories.Generic
{
    public class RepositoryPublicAsyncDapper<TEntity> :
        IRepositoryPublicAsyncDapper<TEntity>
        where TEntity : class , IBaseEntity
    {
        private readonly GenericCommandDbContext DbCommandContext;
        private readonly DbConnectionSetting setting;

        private readonly string TableName =
            typeof(TEntity).Name;

        private readonly HashSet<string> PropertyNames =
            typeof(TEntity)
                .GetProperties()
                .Select(p => p.Name)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);


        public RepositoryPublicAsyncDapper(
            GenericCommandDbContext dbCommandContext,
            DbConnectionSetting setting)
        {
            DbCommandContext = dbCommandContext;
            this.setting = setting;
        }


        #region Get By Id

        public async Task<TEntity?> GetByIdQueryAsync(
            long id)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;

            var sql = $"""
                SELECT *
                FROM [{TableName}]
                WHERE IsDeleted = 0
                  AND {idProperty} = @Id
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            return await connection.QueryFirstOrDefaultAsync<TEntity>(
                sql,
                new { id });
        }

        #endregion


        #region Get By Range Id

        public async Task<GreadData<TEntity>> GetByRangIdQuerAsync(
            List<long> ids)
        {
            var data = new GreadData<TEntity>();

            if (ids == null || ids.Count == 0)
            {
                data.Data = Enumerable.Empty<TEntity>();
                return data;
            }

            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;


            var sql = $"""
                SELECT *
                FROM [{TableName}]
                WHERE IsDeleted = 0
                  AND {idProperty} IN @Ids
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            var result = await connection.QueryAsync<TEntity>(
                sql,
                new { Ids = ids });

            data.Data = result;

            return data;
        }

        #endregion


        #region Get Query

        public virtual async Task<GreadData<TEntity>> GetByQueryAsync(
            CancellationToken cancellationToken,
            GreadData<TEntity> data)
        {
            return await GetPagedDataAsync(
                data,
                isDeleted: false,
                cancellationToken);
        }

        #endregion


        #region Get Deleted Items

        public virtual async Task<GreadData<TEntity>>
            GetByQueryDeletedItemsAsync(
                CancellationToken cancellationToken,
                GreadData<TEntity> data)
        {
            return await GetPagedDataAsync(
                data,
                isDeleted: true,
                cancellationToken);
        }

        #endregion


        #region Get Deleted By Id

        public async Task<GreadData<TEntity>>
            GetByIdDeletedItemQueryAsync(long id)
        {
            var data = new GreadData<TEntity>();

            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;


            var sql = $"""
                SELECT *
                FROM [{TableName}]
                WHERE IsDeleted = 1
                  AND {idProperty} = @Id
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            data.Entity =
                await connection.QueryFirstOrDefaultAsync<TEntity>(
                    sql,
                    new { id });

            return data;
        }

        #endregion


        #region Insert

        public async Task<bool> AddByDapperAsync(
            TEntity entity)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;


            var properties = typeof(TEntity)
                .GetProperties()
                .Where(p => p.Name != idProperty)
                .ToList();

            var columns = string.Join(
                ", ",
                properties.Select(p => $"[{p.Name}]"));

            var parameters = string.Join(
                ", ",
                properties.Select(p => $"@{p.Name}"));

            var sql = $"""
                INSERT INTO [{TableName}]
                ({columns})
                VALUES
                ({parameters})
                """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            var affectedRows =
                await connection.ExecuteAsync(
                    sql,
                    entity);

            return affectedRows > 0;
        }

        #endregion


        #region Update

        public async Task<bool> UpdateByDapperAsync(
            TEntity entity)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;

            var properties = typeof(TEntity)
                .GetProperties()
                .Where(p => p.Name != idProperty)
                .ToList();

            var setClause = string.Join(
                ", ",
                properties.Select(p =>
                    $"[{p.Name}] = @{p.Name}"));

            var sql = $"""
                UPDATE [{TableName}]
                SET {setClause}
                WHERE {idProperty} = @Id
                """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            var affectedRows =
                await connection.ExecuteAsync(
                    sql,
                    entity);

            return affectedRows > 0;
        }

        #endregion


        #region Soft Delete

        public async Task<bool> DeleteAsync(long id)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;

            var sql = $"""
                UPDATE [{TableName}]
                SET IsDeleted = 1
                WHERE {idProperty} = @Id
                  AND IsDeleted = 0
                """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            var affectedRows =
                await connection.ExecuteAsync(
                    sql,
                    new { Id = id });

            return affectedRows > 0;
        }

        #endregion


        #region Restore

        public async Task<bool> RestoreAsync(long id)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;

            var sql = $"""
                UPDATE [{TableName}]
                SET IsDeleted = 0
                WHERE {id} = @Id
                  AND IsDeleted = 1
                """;

            using var connection =
                new SqlConnection(setting.CommandConnectionString);

            var affectedRows =
                await connection.ExecuteAsync(
                    sql,
                    new { id });

            return affectedRows > 0;
        }

        #endregion


        #region Exists

        public async Task<bool> ExistsAsync(long id)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;

            var sql = $"""
                SELECT CAST(
                    CASE
                        WHEN EXISTS
                        (
                            SELECT 1
                            FROM [{TableName}]
                            WHERE {idProperty} = @Id
                              AND IsDeleted = 0
                        )
                        THEN 1
                        ELSE 0
                    END
                AS BIT)
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            return await connection.ExecuteScalarAsync<bool>(
                sql,
                new { Id = id });
        }

        #endregion


        #region Count

        public async Task<int> CountAsync(
            CancellationToken cancellationToken = default)
        {
            var sql = $"""
                SELECT COUNT(1)
                FROM [{TableName}]
                WHERE IsDeleted = 0
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            var command = new CommandDefinition(
                sql,
                cancellationToken: cancellationToken);

            return await connection.ExecuteScalarAsync<int>(
                command);
        }

        #endregion


        #region Private Pagination

        private async Task<GreadData<TEntity>> GetPagedDataAsync(
            GreadData<TEntity> data,
            bool isDeleted,
            CancellationToken cancellationToken)
        {
            var entityType = DbCommandContext.Model.FindEntityType(typeof(TEntity));

            var key = entityType?.FindPrimaryKey();

            var idProperty = key?.Properties.FirstOrDefault()?.Name;


            if (data.Page <= 0)
                data.Page = 1;

            if (data.PageSize <= 0)
                data.PageSize = 20;

            var parameters = new DynamicParameters();

            var sql = $"""
                FROM [{TableName}]
                WHERE IsDeleted = @IsDeleted
                """;

            parameters.Add(
                "@IsDeleted",
                isDeleted,
                DbType.Boolean);

            
            if (data.Filter != null)
            {
                var filterIndex = 0;

                foreach (var filter in data.Filter)
                {
                    /*
                     * Property Name نمی‌تواند Parameter باشد.
                     * بنابراین باید Whitelist شود.
                     */
                    if (!PropertyNames.Contains(filter.Property))
                    {
                        throw new ArgumentException(
                            $"Invalid filter property: {filter.Property}");
                    }

                    var parameterName =
                        $"FilterValue{filterIndex}";

                    sql +=
                        $" AND [{filter.Property}] LIKE @{parameterName}";

                    parameters.Add(
                        parameterName,
                        $"%{filter.Value}%");

                    filterIndex++;
                }
            }

            
            
              // تعداد کل رکوردها
             
            var countSql = $"""
                SELECT COUNT(1)
                {sql};
                """;

            
            // Pagination
             
            var offset =
                (data.Page - 1) * data.PageSize;

            parameters.Add("Offset", offset);
            parameters.Add("PageSize", data.PageSize);

            var dataSql = $"""
                SELECT *
                {sql}
                ORDER BY {idProperty}
                OFFSET @Offset ROWS
                FETCH NEXT @PageSize ROWS ONLY;
                """;

            using var connection =
                new SqlConnection(setting.QueryConnectionString);

            await connection.OpenAsync(cancellationToken);

            
             // Count + Data در یک Round Trip
             
            var command = new CommandDefinition(
                $"{countSql}\n{dataSql}",
                parameters,
                cancellationToken: cancellationToken);

            using var multi =
                await connection.QueryMultipleAsync(command);

            data.Count =
                await multi.ReadFirstAsync<int>();

            data.Data =
                (await multi.ReadAsync<TEntity>())
                .ToList();

            data.PageCount =
                data.Count == 0
                    ? 0
                    : (int)Math.Ceiling(
                        (double)data.Count /
                        data.PageSize);

            return data;
        }

        #endregion
    }
}

