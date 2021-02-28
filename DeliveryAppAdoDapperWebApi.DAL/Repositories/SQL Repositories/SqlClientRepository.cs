using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlClientRepository : GenericRepository<SqlClient, long>, ISqlClientRepository
    {
        
        private string connectionString;

        private static readonly string _tableName = "clients";
        private static readonly bool _isSoftDelete = true;
        public SqlClientRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, _tableName, _isSoftDelete)
        {
            this.connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(this.connectionString);
        }
        
          public List<SqlClient> getAllWithName(string name)
        {
            string sqlOrderDetails = "SELECT a FROM OrderDetails;";

            IEnumerable<SqlOrder> sqlOrder;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<SqlClient>("SELECT * FROM Users WHERE name = @name", new {name}).ToList();
            }
        }
      
    }
}
