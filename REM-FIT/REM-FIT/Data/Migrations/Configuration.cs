namespace Data.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.RemFitDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        
            
        RemFitDbContext db = new RemFitDbContext();


        protected override void Seed(Data.RemFitDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            // Veritabanı oluşturulurken içerisinde olması istenilen veriler burada tanımlanır ve Add / AddOrUpdate metoduı ile eklenir / güncellenir.
            
            Besin su = new Besin() { BesinAdı = "Su", Birim = Birim.Bardak, Kalori = 0 };
            Besin ekmek = new Besin() { BesinAdı = "Ekmek", Kalori = 50, Birim = Birim.Dilim };
            db.Besins.Add(su);
            db.Besins.Add(ekmek);

            User admin = new User
            {
                Adı = "rauf",
                Soyadı = "gündüz",
                Boy = 1.72,
                Sifre = "1234",
                Email = "mrg588@gmail.com",
                DoğumTarihi = DateTime.Parse("28/03/1988"),
                Kilo = 110,
                KayıtTarihi = DateTime.Parse("2021/11/11"),
                Cinsiyeti = CinsiyetTipi.Erkek
            };
            db.Users.Add(admin);

            //TüketilenBesin TEkmek = new TüketilenBesin() { TüketilenBesinÖğünü = "Öğlen", TüketilenTarih = DateTime.Parse("6/11/2021"), BesinID = ekmek.BesinID };
            //db.TüketilenBesins.Add(TEkmek);

            db.SaveChanges();
        }
    }
    
}
