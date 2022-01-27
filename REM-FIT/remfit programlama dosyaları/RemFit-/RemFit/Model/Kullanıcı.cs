using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemFit.Model
{
    public class Kullanıcı
    {
        public int ID { get; set; }

        public string AdıSoyadı { get; set; }
        public DateTime KayıtTarihi { get; set; }

        public DateTime SonGirisTarihi { get; set; }
    }
}
