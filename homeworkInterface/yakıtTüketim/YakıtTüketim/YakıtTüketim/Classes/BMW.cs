using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakıtTüketim.Abstracts;

namespace YakıtTüketim.Classes
{
    public class BMW : Car
    {
        public BMW() : base("BMW", 80.0) { }

        public override double YakıtTüketiminiHesapla()
        {
            return SaatBasınaYakıtTüketimi;
        }
    }
}
