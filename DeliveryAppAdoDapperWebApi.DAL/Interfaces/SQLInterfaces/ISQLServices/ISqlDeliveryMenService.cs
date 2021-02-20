using System.Collections.Generic;
using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryManagement.DataAccess.Interfaces
{
    public interface ISqlDeliveryMenService
    {
        long AddDeliveryMen(SqlDeliveryMen DeliveryMen);
        
        void UpdateDeliveryMen(SqlDeliveryMen DeliveryMen);
        
        void DeleteDeliveryMen(SqlDeliveryMen DeliveryMen);

        SqlDeliveryMen GetDeliveryMen(long Id);
        
        IEnumerable<SqlDeliveryMen> GetAllDeliveryMen();
    }
}
