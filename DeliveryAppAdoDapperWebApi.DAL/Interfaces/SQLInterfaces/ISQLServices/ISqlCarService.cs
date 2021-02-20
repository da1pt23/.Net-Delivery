using System.Collections.Generic;
using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISqlCarService
    {
        long AddCar(SqlCar car);

        void UpdateCar(SqlCar car);

        void DeleteCar(SqlCar car);
        
        SqlCar GetCarById(long Id);
        
        IEnumerable<SqlCar> GetAllCar();
    }
}