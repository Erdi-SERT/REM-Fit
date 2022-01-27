using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class RemFitDbContext: DbContext
    {
        public RemFitDbContext() : base("ConnString")
        {
            //Database.SetInitializer<RemFitDbContext>(new f
        }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("REM-FIT").Configurations.Add(new GenderEntityConfiguration()).Add(new UserEntityConfiguration()).Add(new TüketilenBesinEntityConfiguration()).Add(new BesinEntityConfiguration()).Add(new SuTakibiEntityConfiguration());      
        //}
       

        public DbSet<User> Users { get; set; }

        public DbSet<Besin> Besins { get; set; }

       

        public DbSet<TüketilenÖğün> TüketilenÖğüns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new TüketilenÖğünEntityConfiguration());
            modelBuilder.Configurations.Add(new BesinEntityConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
