using SkillManagement.DataAccess.Entities.SQLEntities;
using System.Collections.Generic;

namespace SkillManagement.DataAccess.Interfaces
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
