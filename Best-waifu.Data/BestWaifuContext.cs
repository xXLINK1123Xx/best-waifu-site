using System.Data.Entity.Infrastructure;
using BestWaifu.Data.Interfaces;
using BestWaifu.Data.Entities;

namespace BestWaifu.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BestWaifuContext : DbContext, IDataContext
    {
        public BestWaifuContext()
            : base("name=BestWaifuContext.mdf")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Character>()
                .HasRequired(c => c.Name);
         
        }

        #region DataSets

        public virtual DbSet<Character> MyEntities { get; set; }


        #endregion

        public IQueryable<T> Find<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void MarkAsAdded<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void MarkAsDeleted<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void MarkAsModified<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Commit(bool withLogging)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void EnableTracking(bool isEnable)
        {
            throw new NotImplementedException();
        }

        public EntityState GetEntityState<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void SetEntityState<T>(T entity, EntityState state) where T : class
        {
            throw new NotImplementedException();
        }

        public DbChangeTracker GetChangeTracker()
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry GetDbEntry<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}