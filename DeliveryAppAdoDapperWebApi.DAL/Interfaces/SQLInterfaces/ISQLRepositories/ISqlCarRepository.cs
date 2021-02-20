using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISqlCarRepository : IGenericRepository<SqlCar, long>
    {
    }
}
