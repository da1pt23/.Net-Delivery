using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using DeliveryAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace DeliveryManagement.DataAccess.Interfaces
{
    public interface ISQLunitOfWork
    {
        ISqlClientRepository IsqlClientRepository { get; }
        ISqlCarRepository IsqlCarRepository { get; }
        ISqlDeliveryMenRepository IsqlDeliveryMenRepository { get; }
        ISqlCallRepository IsqlCallRepository { get; }
        ISqlOrderRepository IsqlOrderRepository { get; }

        void Complete();
    }
}
