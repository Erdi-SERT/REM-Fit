using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Model
{
   public  class BoxProduct:Product
    {
        
        public int? UnitsInBox { get; set; }
        //Nesnenin sonuna soru işareti koyarak nullable olacağını belirtik
    }
}
