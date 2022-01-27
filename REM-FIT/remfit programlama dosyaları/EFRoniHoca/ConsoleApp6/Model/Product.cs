using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp6.Model
{
    [Table ("Ürün",Schema ="Grup")]
    public class Product
    {
        
        [Column("Ürün ID")]
        [Key]   //Bu alttaki satırın primary kery olduğunu belirtmemize sağlar
        public int ProductCode{ get; set; }
        [Required]
        [StringLength(50)]
        public string Name{ get; set; }
        [Column(TypeName = "float")]
        public double Price { get; set; }
        [StringLength(10,MinimumLength =6,ErrorMessage ="Barkod en az 6 en fazla 10 karekterden oluşmalı") ]
        public string Barcode { get; set; }

        // Tekrar Edilecek[ForeignKey("Standart")]  
        public int KategoriKodu { get; set; }

        [Required]

        public Category Category{ get; set; }


        
    }
}
