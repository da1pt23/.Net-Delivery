using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace DeliveryManagement.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        ISqlCarRepository IsqlCarRepository { get; }
        ISqlCallRepository IsqlCallRepository { get; }
    }
}
