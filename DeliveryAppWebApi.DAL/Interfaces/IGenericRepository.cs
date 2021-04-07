using System.Collections.Generic;

namespace DeliveryManagement.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TId Id);
        
        long Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
