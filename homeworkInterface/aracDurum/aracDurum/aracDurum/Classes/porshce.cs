using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aracDurum.Interfaces;

namespace aracDurum.Classes
{
  public class Porsche:Car,IAracDurum
    {
        public void denizdeYüz(string isim)
        {
            throw new NotImplementedException();
        }

        public void havadaUc(string isim)
        {
            Console.WriteLine(isim + " havada uçar...");
        }

        public void hızlıGit(string isim)
        {
            throw new NotImplementedException();
        }
    }
}
