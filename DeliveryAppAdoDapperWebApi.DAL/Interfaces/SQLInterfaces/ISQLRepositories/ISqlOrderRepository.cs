using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlOrderRepository : IGenericRepository<SqlOrder, long>
    {
    }
}