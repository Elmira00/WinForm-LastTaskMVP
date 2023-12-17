using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16.Model
{
    public class Benzin

    {
        public int BenzinId { get; set; }//primary key of DataBase
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
