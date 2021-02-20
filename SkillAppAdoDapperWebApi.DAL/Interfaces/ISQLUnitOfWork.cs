using SkillAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace SkillManagement.DataAccess.Interfaces
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
