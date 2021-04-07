using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryAppWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using Delivery.DataAccess.Core;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlOrderRepository : GenericRepository<SqlOrder, long>, ISqlOrderRepository
    {
        private string connectionString;

        public SqlOrderRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory,
            "orders", false)
        {
            this.connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(this.connectionString);
        }

        public IEnumerable<SqlOrder>  getHighestFivePriceOrder()
        {
            string sqlOrderDetails = "SELECT * FROM order ORDER BY DESC LIMIT 5;";

            IEnumerable<SqlOrder> sqlOrder;
            using (var connection = new SqlConnection(connectionString))
            {
                sqlOrder = connection.Query<SqlOrder>(sqlOrderDetails);
            }
            return sqlOrder;
        }
        
    }
}