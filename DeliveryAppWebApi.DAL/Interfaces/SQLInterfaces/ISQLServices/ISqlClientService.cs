using System.Collections.Generic;
using DeliveryManagement.DataAccess.Entities.SQLEntities;

namespace DeliveryManagement.DataAccess.Interfaces
{
    public interface ISqlClientService
    {
        long AddClient(SqlClient client);

        void UpdateClient(SqlClient client);

        void DeleteClient(SqlClient client);
        
        SqlClient GetClientById(long Id);
        
        IEnumerable<SqlClient> GetAllClients();
    }
}
