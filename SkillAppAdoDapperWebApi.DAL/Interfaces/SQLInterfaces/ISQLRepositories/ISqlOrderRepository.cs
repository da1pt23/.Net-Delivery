using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;

namespace SkillAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlOrderRepository : IGenericRepository<SqlOrder, long>
    {
    }
}