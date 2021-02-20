using System.Collections.Generic;
using SkillManagement.DataAccess.Entities.SQLEntities;

namespace CallManagement.DataAccess.Interfaces
{
    public interface ISqlCallService
    {
        long AddCall(SqlCall call);

        void UpdateCall(SqlCall call);

        void DeleteCall(SqlCall call);

        SqlCall GetCallById(int Id);

        IEnumerable<SqlCall> GetAllCalls();
    }
}
