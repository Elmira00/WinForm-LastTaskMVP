using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp16.Model;

namespace WindowsFormsApp16.Data
{
    public class BenzinContext:DbContext
    {
        public BenzinContext()
            :base("BenzinDB")
        {
        }
        public DbSet<Benzin> Benzins { get; set; }

    }
}
