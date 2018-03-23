using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BestWaifu.Data.Interfaces
{
    public interface IDataContext
    {
        IQueryable<T> Find<T>() where T : class;

        void MarkAsAdded<T>(T entity) where T : class;

        void MarkAsDeleted<T>(T entity) where T : class;

        void MarkAsModified<T>(T entity) where T : class;

        void Commit(bool withLogging);
        
        void Rollback();
        
        void EnableTracking(bool isEnable);

        EntityState GetEntityState<T>(T entity) where T : class;

        void SetEntityState<T>(T entity, EntityState state) where T : class;
        
        DbChangeTracker GetChangeTracker();

        DbEntityEntry GetDbEntry<T>(T entity) where T : class;
        }
}