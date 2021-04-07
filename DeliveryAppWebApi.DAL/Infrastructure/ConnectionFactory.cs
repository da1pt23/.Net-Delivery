using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using DeliveryManagement.DataAccess.Interfaces;

namespace Delivery.DataAccess.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        private static string _connectionString;

        public ConnectionFactory(IConfiguration config)
        {
            _configuration = config;
        }
        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

                connection.Open();

                return connection;
            }
        }
    }
}
