using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkInheritance.Classes
{
    public class Car
    {
        public string Marka;
        public string VitesTuru;

        public void car(string marka, string vitesTuru)
        {
            Marka = marka;
            VitesTuru = vitesTuru;
            Console.WriteLine("Aracın markası: " + Marka + " Aracın vites türü: " + VitesTuru);
        }
    }
}
