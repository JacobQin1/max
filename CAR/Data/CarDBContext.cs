using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class CarDBContext:DbContext
    {
        public CarDBContext():base("name=CARDB")
        {

        }
        public DbSet<data> Datas { get; set; }

    }
}
