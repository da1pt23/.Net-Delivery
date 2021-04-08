using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlCarRepository : IGenericRepository<SqlCar>
    {
        public SqlCar GetById(long id);
    }
}