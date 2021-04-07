using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryAppWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlOrderRepository : IGenericRepository<SqlOrder, long>
    {
    }
}