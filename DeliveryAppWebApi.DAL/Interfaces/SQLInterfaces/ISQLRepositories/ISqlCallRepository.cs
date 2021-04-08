using System.Linq;
using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlCallRepository : IGenericRepository<SqlCall>
    {
        public SqlCall GetById(long id);

        public IQueryable<SqlCall> GetFinishedCalls();
    }

}