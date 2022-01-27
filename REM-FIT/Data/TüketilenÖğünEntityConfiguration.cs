
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Data
{
    public class TüketilenÖğünEntityConfiguration : EntityTypeConfiguration<TüketilenÖğün>
    {
        public TüketilenÖğünEntityConfiguration()
        {
            ToTable("TüketildiğiÖğün");
            HasKey(t => t.TüketilenID);

            Property(t => t.TüketilenID).HasColumnName("TüketilenBesinID").IsRequired().HasColumnType("INT").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.TüketildiğiÖğün).IsRequired().HasColumnName("TüketildiğiÖğün");

            Property(t => t.BesinID).IsRequired().HasColumnName("BesinID");

            Property(t => t.BesinAdı).IsRequired().HasColumnName("BesinAdı");

            Property(t => t.TüketilenTarih).IsRequired().HasColumnName("TükedildiğiTarih");

            Property(t => t.Miktar).HasColumnName("Miktarı");
          
            //Property(t => t.UserID.UserID);

            //
            //HasOptional(t => t.User).WithMany(u => u.TüketilenÖğüns).HasForeignKey(t => t.TüketilenID);

            HasMany(t => t.Besins).WithMany(b => b.TüketilenÖğüns).Map(bb =>
            {
                bb.ToTable("BesininTüketildiğiÖğün");
                bb.MapRightKey("TüketilenID");
                bb.MapLeftKey("BesinID");
            });




        }
    }
}
