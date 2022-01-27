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
            Besin ekmek = new Besin() { BesinAdı = "Ekmek", Kalori = 264, Birim = Birim.Dilim };
            Besin pekmez = new Besin() { BesinAdı = "Pekmez", Kalori = 30, Birim = Birim.Kaşık };
            Besin tahin = new Besin() { BesinAdı = "Tahin", Kalori = 90, Birim = Birim.Dilim };
            Besin et = new Besin() { BesinAdı = "Et", Kalori = 200, Birim = Birim.Porsiyon };
            Besin tavuk = new Besin() { BesinAdı = "Tavuk", Kalori = 165, Birim = Birim.Porsiyon };
            
            db.Besins.Add(su);
            db.Besins.Add(ekmek);
            db.Besins.Add(pekmez);
            db.Besins.Add(tahin);
            db.Besins.Add(et);
            db.Besins.Add(tavuk);

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
                Cinsiyeti = CinsiyetTipi.Erkek,
                KullanıcıTipi=0                
            };
            User admin1 = new User
            {
                Adı = "Erdi",
                Soyadı = "SERT",
                Boy = 1.72,
                Sifre = "1234",
                Email = "erdisert@gmail.com",
                DoğumTarihi = DateTime.Parse("10/08/1992"),
                Kilo = 76,
                KayıtTarihi = DateTime.Parse("2021/11/11"),
                Cinsiyeti = CinsiyetTipi.Erkek,
                KullanıcıTipi = 0
            };
            User admin2 = new User
            {
                Adı = "Merve",
                Soyadı = "ARSLAN ÇELİK",
                Boy = 1.64,
                Sifre = "1234",
                Email = "mervearslancelik@gmail.com",
                DoğumTarihi = DateTime.Parse("07/01/1989"),
                Kilo = 68,
                KayıtTarihi = DateTime.Parse("2021/11/11"),
                Cinsiyeti = CinsiyetTipi.Kadın,
                KullanıcıTipi = 0
            };
            db.Users.Add(admin);
            db.Users.Add(admin1);
            db.Users.Add(admin2);
            db.SaveChanges();
        }

    }
}
