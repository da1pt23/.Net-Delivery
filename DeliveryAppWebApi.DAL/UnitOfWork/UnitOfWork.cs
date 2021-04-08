using System;
using DeliveryManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace DeliveryManagement.DataAccess.sqlunitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISqlCarRepository _isqlCarRepository;
        private readonly ISqlCallRepository _isqlCallRepository;
        
        public UnitOfWork(
            ISqlCarRepository isqlCarRepository,
            ISqlCallRepository isqlCallRepository
        )
        {
            _isqlCarRepository = isqlCarRepository;
            _isqlCallRepository = isqlCallRepository;
        }

        public ISqlCarRepository IsqlCarRepository
        {
            get
            {
                return _isqlCarRepository;
            }
        }

        public ISqlCallRepository IsqlCallRepository
        {
            get
            {
                return _isqlCallRepository;
            }
        }

    }
}
