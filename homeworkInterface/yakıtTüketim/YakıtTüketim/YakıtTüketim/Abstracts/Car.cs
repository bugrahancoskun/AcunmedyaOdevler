using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakıtTüketim.Interfaces;

namespace YakıtTüketim.Abstracts
{
    public abstract class Car:IYakıtTüketimi
    {
        public string Marka { get; set; }
        public double SaatBasınaYakıtTüketimi{ get; set; }

        public Car(string marka, double saatBasınaYakıtTüketimi)
        {
            Marka = marka;
            SaatBasınaYakıtTüketimi = saatBasınaYakıtTüketimi;
        }

        public abstract double YakıtTüketiminiHesapla();
    }
}
