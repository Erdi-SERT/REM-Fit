using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// Key i almka için
using System.ComponentModel.DataAnnotations.Schema; //dataannotaviouns

namespace ConsoleApp6.Model
{
    [Table("Kategori",Schema ="Grup")]
   public class Category
    {
        [Key]
        [Column ("Kategori ID")]
        public int ID{ get; set; }
        [Column("Kategori Adı",TypeName ="varchar")]
        [Index(IsClustered = false, IsUnique = true)]
        [Required]  
        //Clustered Fiziksel olarak neye göre sıralanacağını belirtir.
        //Ararken çok hızlı bulmamaızı yarar(Avantaj)
        //Sıralı gelemeyenler için ekleme aşamasında avaşlatır(Dezavantaj)
        //Required zorunlu girilmesi gereken alanı gösterir

        public string   Name { get; set; }
       
        public string Description{ get; set; }
    }
}
