using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            ToTable("Kullanıcılar");
            HasKey(u => u.UserID);
            Property(u => u.UserID).HasColumnName("UserID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.Adı).IsRequired().HasColumnName("Ad");
            Property(u => u.Soyadı).IsRequired().HasColumnName("Soyadı");
            Property(u => u.Sifre).IsRequired().HasColumnName("Sifre");
            Property(u => u.Email).IsRequired().HasColumnName("EMail");
            Property(u => u.DoğumTarihi).IsOptional().HasColumnName("DoğumTarihi");
            Property(u => u.Cinsiyeti).HasColumnName("Cinsiyeti");
            Property(u => u.KullanıcıTipi).HasColumnName("KullanıcıTipi");
            
            Property(u => u.Kilo).IsRequired().HasColumnName("Kilo");
            Property(u => u.Boy).IsRequired().HasColumnName("Boy");
            Property(u => u.KayıtTarihi).HasColumnName("KayıtTarihi");

            //Relations
                      
            //HasMany(u => u.TüketilenÖğüns).WithOptional(t => t.User).HasForeignKey(t=>t.TüketilenID);





        }
    }
}
