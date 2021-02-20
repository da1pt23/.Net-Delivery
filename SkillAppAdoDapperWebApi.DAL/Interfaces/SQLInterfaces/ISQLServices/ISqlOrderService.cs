using SkillManagement.DataAccess.Entities.SQLEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices
{
    public interface ISqlOrderService
    {
        long AddOrder(SqlOrder Order);

        void UpdateOrder(SqlOrder Order);

        void DeleteOrder(SqlOrder Order);
        
        SqlOrder GetOrderById(long Id);
        
        IEnumerable<SqlOrder> GetAllOrders();

    }
}
