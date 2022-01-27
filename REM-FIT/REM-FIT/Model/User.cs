using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //kullanıcı tipi enum ile eklenecek
    public enum CinsiyetTipi { Erkek, Kadın }
    public enum KullanıcıTipi { Admin, Kullannıcı }
    public class User
    {
        public int UserID { get; set; }  //Analiz raporundaki Kullanıcı ID kısmı
        //public int GenderID { get; set; }  //enum yapılacak
        public KullanıcıTipi KullanıcıTipi { get; set; }//enum yapılacak 
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Email { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public CinsiyetTipi Cinsiyeti { get; set; }
        public string Sifre { get; set; }
        public double Kilo { get; set; }
        public double Boy { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public ICollection<TüketilenÖğün> TüketilenÖğüns { get; set; }
       //Bire çok ilişki var 

        public User()
        {
            TüketilenÖğüns = new List<TüketilenÖğün>();
        }

    }
}
