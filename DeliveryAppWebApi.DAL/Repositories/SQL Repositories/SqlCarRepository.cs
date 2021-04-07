using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using Delivery.DataAccess.Core;

namespace DeliveryManagement.DataAccess.Repositories.SQL_Repositories
{
    public class SqlCarRepository : GenericRepository<SqlCar, long>, ISqlCarRepository
    {
        private static readonly string _tableName = "cars";
        
        public SqlCarRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, false)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(connectionString);
        }
    }
}
