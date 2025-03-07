using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakıtTüketim.Abstracts;

namespace YakıtTüketim.Classes
{
    public class Mercedes : Car
    {
        public Mercedes() : base("Mercedes", 70.0) { }

        public override double YakıtTüketiminiHesapla()
        {
            return SaatBasınaYakıtTüketimi;
        }
    }
}
