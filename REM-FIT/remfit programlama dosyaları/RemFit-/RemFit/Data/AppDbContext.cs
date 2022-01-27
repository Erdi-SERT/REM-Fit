using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemFit.Model;


namespace RemFit
{
   public class AppDbContext:DbContext
    {

        public AppDbContext():base("name = RemFitEntities")
        {            
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
        }                   
        public DbSet<Kullanıcı> KullanıcıDb { get; set; }
        public DbSet<Su> SuDb { get; set; }
        public DbSet<Tarifler> TariflerDb { get; set; }
        
    }
    
}
