using System.Linq;
using Delivery.DataAccess.Core;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.EntityFrameworkCore;

namespace DeliveryManagement.DataAccess.Repositories
{
    public class SqlCallRepository : GenericRepository<SqlCall>, ISqlCallRepository
    {
        public SqlCallRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public SqlCall GetById(long id)
        {
            return _context.Calls
                .Include(call => call.Client)
                .Include(call => call.Deliveryman)
                .Include(call => call.Order)
                .ToList()
                .FirstOrDefault();
        }

        public IQueryable<SqlCall> GetFinishedCalls()
        {
            return from c in _context.Calls
                where c.CallStatus.Equals("Finished")
                select c;
        }
    }
    
}