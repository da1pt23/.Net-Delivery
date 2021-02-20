using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLServices;

namespace SkillManagement.DataAccess.Services
{
    public class SqlCarService : ISqlCarService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SqlCarService(ISQLunitOfWork sqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlunitOfWork;
        }
        public long AddCar(SqlCar order)
        {
            return _SqlsqlunitOfWork.IsqlCarRepository.Add(order);
        }

        public void DeleteCar(SqlCar order)
        {
            _SqlsqlunitOfWork.IsqlCarRepository.Delete(order);
        }

        public SqlCar GetCarById(long Id)
        {
            return _SqlsqlunitOfWork.IsqlCarRepository.Get(Id);
        }

        public IEnumerable<SqlCar> GetAllCar()
        {
            return _SqlsqlunitOfWork.IsqlCarRepository.GetAll();
        }

        public void UpdateCar(SqlCar order)
        {
            _SqlsqlunitOfWork.IsqlCarRepository.Update(order);
        }
    }
}
