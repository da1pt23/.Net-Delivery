using Microsoft.Extensions.Configuration;
using System.Configuration;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlCallRepository : GenericRepository<SqlCall, long>, ISqlCallRepository
    {
        public SqlCallRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, "call", false)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(connectionString);
        }
    }
}
