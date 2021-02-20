using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using SkillAppAdoDapperWebApi.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace SkillManagement.DataAccess.sqlunitOfWork
{
    public class SQLsqlunitOfWork : ISQLunitOfWork
    {
        private readonly ISqlClientRepository _isqlClientRepository;
        private readonly ISqlCarRepository _isqlCarRepository;
        private readonly ISqlDeliveryMenRepository _isqlDeliveryMenRepository;
        private readonly ISqlCallRepository _isqlCallRepository;
        private readonly ISqlOrderRepository _isqlOrderRepository;
        
        public SQLsqlunitOfWork(ISqlClientRepository isqlClientRepository,
            ISqlCarRepository isqlCarRepository,
            ISqlDeliveryMenRepository isqlDeliveryMenRepository,
            ISqlCallRepository isqlCallRepository,
            ISqlOrderRepository isqlOrderRepository
            )
        {
            _isqlClientRepository = isqlClientRepository;
            _isqlCarRepository = isqlCarRepository;
            _isqlDeliveryMenRepository = isqlDeliveryMenRepository;
            _isqlCallRepository = isqlCallRepository;
            _isqlOrderRepository = isqlOrderRepository;
        }
        public ISqlClientRepository IsqlClientRepository
        {
            get
            {
                return _isqlClientRepository;
            }
        }

        public ISqlCarRepository IsqlCarRepository
        {
            get
            {
                return _isqlCarRepository;
            }
        }

        public ISqlDeliveryMenRepository IsqlDeliveryMenRepository
        {
            get
            {
                return _isqlDeliveryMenRepository;
            }
        }

        public ISqlCallRepository IsqlCallRepository
        {
            get
            {
                return _isqlCallRepository;
            }
        }

        public ISqlOrderRepository IsqlOrderRepository
        {
            get
            {
                return _isqlOrderRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
