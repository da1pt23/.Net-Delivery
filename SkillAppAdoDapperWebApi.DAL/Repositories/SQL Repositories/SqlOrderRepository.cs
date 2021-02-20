using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Configuration;
using SkillAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace SkillManagement.DataAccess.Repositories
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