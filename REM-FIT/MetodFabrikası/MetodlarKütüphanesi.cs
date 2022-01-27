using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MetodFabrikası
{
    public class MetodlarKütüphanesi
    {
        public string VKIHesapla(double boy, double kilo)
        {
            double vki = kilo / (boy * boy);
            string sonuc = "";

            if (vki < 18)
            {
                sonuc = "Zayıf";
            }
            else if (18 < vki && vki < 25)
            {
                sonuc = "Normal";
            }
            else if (25 < vki && vki < 30)
            {
                sonuc = "Fazla Kilolu";
            }
            else if (30 < vki && vki < 40)
            {
                sonuc = "Obez";
            }
            else if (40 < vki)
            {
                sonuc = "İleri Derece Obez";
            }
            return sonuc;
        }
    }
}
