using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Data;
using System.Data.Entity;

namespace Data
{
    public class RemFitDbInitilizer : DropCreateDatabaseAlways<RemFitDbContext>
    {
        protected override void Seed(RemFitDbContext context)
        {
            


            base.Seed(context);

        }
    }
}
