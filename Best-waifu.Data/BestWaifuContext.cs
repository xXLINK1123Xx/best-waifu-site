using BestWaifu.Data.Entities;
using System.Data.Entity;

namespace BestWaifu.Data
{

    public class BestWaifuContext : DbContext
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
        
    }
}