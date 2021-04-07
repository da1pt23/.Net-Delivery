using System.Collections.Generic;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using DeliveryManagement.DataAccess.Interfaces;

namespace DeliveryManagement.DataAccess.Services
{
    public class SqlClientService : ISqlClientService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SqlClientService(ISQLunitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public long AddClient(SqlClient client)
        {
            return _SqlsqlunitOfWork.IsqlClientRepository.Add(client);
        }

        public void DeleteClient(SqlClient client)
        {
            _SqlsqlunitOfWork.IsqlClientRepository.Delete(client);
        }

        public IEnumerable<SqlClient> GetAllClients()
        {
            return _SqlsqlunitOfWork.IsqlClientRepository.GetAll();
        }

        public SqlClient GetClientById(long Id)
        {
            return _SqlsqlunitOfWork.IsqlClientRepository.Get(Id);
        }

        public void UpdateClient(SqlClient client)
        {
            _SqlsqlunitOfWork.IsqlClientRepository.Update(client);
        }
    }
}
