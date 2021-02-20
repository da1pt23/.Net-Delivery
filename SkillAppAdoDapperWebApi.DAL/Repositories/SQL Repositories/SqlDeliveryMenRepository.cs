using Microsoft.Extensions.Configuration;
using SkillManagement.DataAccess.Core;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System.Configuration;

namespace SkillManagement.DataAccess.Repositories
{
    public class SqlDeliveryMenRepository : GenericRepository<SqlDeliveryMen, long>, ISqlDeliveryMenRepository
    {
        public SqlDeliveryMenRepository(IConnectionFactory connectionFactory, IConfiguration config) : base(connectionFactory, "deliverymen", false)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            connectionFactory.SetConnection(connectionString);
        }
    }
}
