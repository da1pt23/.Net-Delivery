using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using DeliveryManagement.DataAccess.Interfaces;
using Npgsql;    

namespace DeliveryManagement.DataAccess.Infrastructure
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
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" + 
                                                             "Password=admin;Database=delivery;");
                conn.Open();

                return conn;
            }
        }
    }
}
