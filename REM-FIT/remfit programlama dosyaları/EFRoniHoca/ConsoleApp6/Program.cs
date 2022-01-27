using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Data;
using ConsoleApp6.Model;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationonDbContext app = new ApplicationonDbContext(VeriTabanYaratmaModelleri.HerZamanYeniVEriTabanıYarat))  // süslü parantez içinde yarattığımız nesneyi kullanmamıza yarar   (using)                                                                            
            {
                Category Kırtasiye = new Category() { ID = 1, Name = "Kırsatiye" };
                Category Tuafiye = new Category() { ID = 2, Name = "Tuafiye" };
                Product Defter = new Product();
                Defter.ProductCode = 1;
                Defter.Name = "Defter";
                Defter.Price = 12.25;
                Defter.Category = Kırtasiye;
                Defter.Barcode = "1234567";
                Defter.Category.Description = "DenemeAmaclı";

                BoxProduct KalemKutusu = new BoxProduct();
                KalemKutusu.Name = "Kalem";
                KalemKutusu.Category = Kırtasiye;
                KalemKutusu.Price = 25;
                KalemKutusu.UnitsInBox = 12;
                KalemKutusu.Barcode = "123456789";

               app.Categories.Add(Kırtasiye);
               app.Categories.Add(Tuafiye);
               app.Products.Add(Defter);
               app.BoxProducts.Add(KalemKutusu);
               app.Categories.Remove(Kırtasiye);//Bu şekildede çıkardık

               app.SaveChanges();


            }  
        }
        //CodeFirst ilerliyoruz
    }
}
