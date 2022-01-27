using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //miktar için enum ekle
    public enum Birim { Gram, Adet, Porsiyon, Bardak, Kaşık,Dilim }
    public class Besin
    {
        //[] kendi ID versin diye ne ekleyeceğiz
        public int BesinID { get; set; } //1
        public string BesinAdı { get; set; }  //Ekmek
        public Birim Birim { get; set; }        
        public int Kalori { get; set; }  //200kalori
        public ICollection<TüketilenÖğün> TüketilenÖğüns { get; set; }
        public Besin()
        {
            TüketilenÖğüns = new List<TüketilenÖğün>();
        }


    }
}
