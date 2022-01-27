using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class BesinEntityConfiguration : EntityTypeConfiguration<Besin>
    {

        public BesinEntityConfiguration()
        {
            ToTable("Besinler");

            //BesinID
            HasKey(b => b.BesinID);
            Property(b => b.BesinID).HasColumnName("BesinID").HasColumnType("INT").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //BesinAdı
            Property(b => b.BesinAdı).IsRequired().HasColumnName("BesinAdı").HasMaxLength(20);
             
            Property(b => b.Birim).HasColumnName("Birimi");
            //Relations
            //tüketilenöğünde oluşturulduğu için buraya eklenmedi
        }
    }
}
