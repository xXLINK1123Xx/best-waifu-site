using Best_waifu.Data.Entities;

namespace Best_waifu.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BestWaifuContext : DbContext
    {
        // Your context has been configured to use a 'BestWaifuContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Best_waifu.Data.BestWaifuContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BestWaifuContext' 
        // connection string in the application configuration file.
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

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Character> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}