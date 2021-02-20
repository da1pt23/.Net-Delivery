using Microsoft.Extensions.Configuration;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Configuration;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlOrderRepository : GenericRepository<SqlOrder, long>, ISqlOrderRepository
    {
        public SqlOrderRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, "order", false)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(connectionString);
        }
    }
}