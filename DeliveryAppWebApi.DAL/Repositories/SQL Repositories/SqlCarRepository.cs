using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryManagement.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using Delivery.DataAccess.Core;

namespace DeliveryManagement.DataAccess.Repositories.SQL_Repositories
{
    public class SqlCarRepository : GenericRepository<SqlCar>, ISqlCarRepository
    {
        public SqlCarRepository(ApplicationContext applicationContext) : base (applicationContext) {
            
        }

        public SqlCar GetById(long id)
        {
                var car = _context.Cars
                    .Single(b => b.Id == id);

                _context.Entry(car)
                    .Reference(car => car.Deliveryman)
                    .Load();

                return car;
        }
    }
}
