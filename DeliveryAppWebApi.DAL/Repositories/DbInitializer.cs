using DeliveryManagement.DataAccess.Entities.SQLEntities;
using Microsoft.EntityFrameworkCore.Internal;

namespace Delivery.DataAccess.Core
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}