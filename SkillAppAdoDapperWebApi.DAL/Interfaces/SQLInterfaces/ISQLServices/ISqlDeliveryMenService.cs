using SkillManagement.DataAccess.Entities.SQLEntities;
using System.Collections.Generic;

namespace SkillManagement.DataAccess.Interfaces
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
