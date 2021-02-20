using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace SkillManagement.DataAccess.Services.SQL_Services
{
    public class SqlDeliveryMenService : ISqlDeliveryMenService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SqlDeliveryMenService(ISQLunitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }
        
        public long AddDeliveryMen(SqlDeliveryMen deliveryMen)
        {
            return _SqlsqlunitOfWork.IsqlDeliveryMenRepository.Add(deliveryMen);
        }

        public void DeleteDeliveryMen(SqlDeliveryMen deliveryMen)
        {
            _SqlsqlunitOfWork.IsqlDeliveryMenRepository.Delete(deliveryMen);
        }

        public IEnumerable<SqlDeliveryMen> GetAllDeliveryMen()
        {
            return _SqlsqlunitOfWork.IsqlDeliveryMenRepository.GetAll();
        }

        public SqlDeliveryMen GetDeliveryMen(long Id)
        {
            return _SqlsqlunitOfWork.IsqlDeliveryMenRepository.Get(Id);
        }

        public void UpdateDeliveryMen(SqlDeliveryMen deliveryMen)
        {
            _SqlsqlunitOfWork.IsqlDeliveryMenRepository.Update(deliveryMen);
        }
    }
}