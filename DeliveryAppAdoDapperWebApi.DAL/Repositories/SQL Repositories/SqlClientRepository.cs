using System.Collections.Generic;
using System.Configuration;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.Extensions.Configuration;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlClientRepository : GenericRepository<SqlClient, long>, ISqlClientRepository
    {
        private static readonly string _tableName = "client";
        private static readonly bool _isSoftDelete = true;
        public SqlClientRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, _isSoftDelete)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(connectionString);
        }
    }
}
