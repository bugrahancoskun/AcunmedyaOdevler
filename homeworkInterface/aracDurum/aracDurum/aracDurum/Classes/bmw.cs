using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aracDurum.Interfaces;

namespace aracDurum.Classes
{
    public class bmw:Car,IAracDurum
    {
        public void hızlıGit(string isim)
        {
            Console.WriteLine(isim + " çok hızlı gider...");
        }
        public void denizdeYüz(string isim)
        {
            Console.WriteLine(isim + " denizde yüzer...");
        }
        public void havadaUc(string isim)
        {
            Console.WriteLine(isim + " havada uçar...");
        }
    }
}
