using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApp6.Model;
namespace ConsoleApp6.Data
{
    public enum VeriTabanYaratmaModelleri { VeriTabanıYokİseYarat, ModelDeğişirseYarat, HerZamanYeniVEriTabanıYarat }
    public class ApplicationonDbContext : DbContext
    //Burada entity using yaptık ardından ise inherit aldık

    {
        public ApplicationonDbContext(VeriTabanYaratmaModelleri VeriTabanıModeli) : base("name=ConsoleApp6.Properties.Settings.DatabaseConnectionString")
            //app.config dosyasında bulunan connectionstring anme bölümünü aldık kopyaladık
        {
            switch (VeriTabanıModeli)
            {
                case VeriTabanYaratmaModelleri.VeriTabanıYokİseYarat:
                    Database.SetInitializer<ApplicationonDbContext>(new CreateDatabaseIfNotExists<ApplicationonDbContext>());
                    break;
                //Veritabanı yok ise yarat

                case VeriTabanYaratmaModelleri.ModelDeğişirseYarat:
                    Database.SetInitializer<ApplicationonDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationonDbContext>());
                    break;
                //Model değişirse yarat

                case VeriTabanYaratmaModelleri.HerZamanYeniVEriTabanıYarat:
                    Database.SetInitializer<ApplicationonDbContext>(new DropCreateDatabaseAlways<ApplicationonDbContext>());
                    break;
                //Her zaman veri tabanı Yarat
                default:
                    break;
            }
            Database.SetInitializer<ApplicationonDbContext>(new CreateDatabaseIfNotExists<ApplicationonDbContext>()); //Veritaba yok ise çalışır


            //  Database.SetInitializer<ApplicationonDbContext>(new crea<ApplicationonDbContext() >); //Veritaba yok ise çalışır

        }

        public DbSet<Category> Categories { get; set; }      //using ile yazınca
        public DbSet<ConsoleApp6.Model.Product> Products { get; set; }       //using yazmadan
        public DbSet<BoxProduct> BoxProducts { get; set; }       //using yazmadan



    }
}
