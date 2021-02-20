using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Configuration;

namespace SkillManagement.DataAccess.Repositories
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
