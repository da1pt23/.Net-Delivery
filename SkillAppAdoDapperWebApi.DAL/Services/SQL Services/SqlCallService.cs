using CallManagement.DataAccess.Interfaces;
using System.Collections.Generic;
using SkillManagement.DataAccess.Entities.SQLEntities;
using SkillManagement.DataAccess.Interfaces;

namespace CallManagement.DataAccess.Services
{
    public class SqlCallService : ISqlCallService
    {
        ISQLunitOfWork _sqlunitOfWork;
        
        public SqlCallService(ISQLunitOfWork sqlunitOfWork)
        {
            _sqlunitOfWork = sqlunitOfWork;
        }
        
        public long AddCall(SqlCall call)
        {
            return _sqlunitOfWork.IsqlCallRepository.Add(call);
        }

        public void DeleteCall(SqlCall call)
        {
            _sqlunitOfWork.IsqlCallRepository.Delete(call);
        }

        public IEnumerable<SqlCall> GetAllCalls()
        {
            return _sqlunitOfWork.IsqlCallRepository.GetAll();
        }

        public SqlCall GetCallById(int Id)
        {
            return _sqlunitOfWork.IsqlCallRepository.Get(Id);
        }

        public void UpdateCall(SqlCall call)
        {
            _sqlunitOfWork.IsqlCallRepository.Update(call);
        }
    }
}
