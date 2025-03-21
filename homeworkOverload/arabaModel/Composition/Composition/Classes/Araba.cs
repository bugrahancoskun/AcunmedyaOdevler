using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Classes
{
    public class Araba
    {
        public Marka Marka { get; set; }
        public Kapi Kapi { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void Yazdir()
        {
            Console.WriteLine($"Arabanın markası {Marka.Ad}, modeli {Marka.Model}, kapı sayısı {Kapi.Sayi}, pencere sayısı {Pencere.Sayi}, kasası {Kasa.Tip}, fiyatı {Fiyat:C}’dir.");
        }
    }
}
