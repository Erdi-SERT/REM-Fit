using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Öğünler { Sabah, öğle, Akşam, AraÖğün }
    public class TüketilenÖğün //:Besin

    //öğünler enum yapılacak
    {
        public int TüketilenID { get; set; }
        public Öğünler TüketildiğiÖğün { get; set; }
        public DateTime TüketilenTarih { get; set; }
        public ICollection<Besin> Besins { get; set; }
        //Besinler olacak
        public double Miktar { get; set; }//miktar
        public User User { get; set; }

        public TüketilenÖğün()
        {
            Besins = new List<Besin>();
        }

    }
}
