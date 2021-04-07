using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;

namespace DeliveryManagement.DataAccess.Services.SQL_Services
{
    public class SqlOrderService : ISqlOrderService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SqlOrderService(ISQLunitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }
        public long AddOrder(SqlOrder Order)
        {
            return _SqlsqlunitOfWork.IsqlOrderRepository.Add(Order);
        }

        public void DeleteOrder(SqlOrder Order)
        {
            _SqlsqlunitOfWork.IsqlOrderRepository.Delete(Order);
        }

        public IEnumerable<SqlOrder> GetAllOrders()
        {
            return _SqlsqlunitOfWork.IsqlOrderRepository.GetAll();
        }

        public SqlOrder GetOrderById(long Id)
        {
            return _SqlsqlunitOfWork.IsqlOrderRepository.Get(Id);
        }

        public void UpdateOrder(SqlOrder Order)
        {
            _SqlsqlunitOfWork.IsqlOrderRepository.Update(Order);
        }
    }
}
