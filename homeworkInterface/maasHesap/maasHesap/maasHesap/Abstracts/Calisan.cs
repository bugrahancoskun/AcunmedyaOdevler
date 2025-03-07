using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maasHesap.Abstracts
{   
    //1.abstract classların nesnesi oluşturulamaz.
    //2.kendisinden türeyen classları eğer abstract class içinde normal metodların dışında
    //abstract keyword ile tanımlanmış bir method varsa o methodu yazmak zorundadırlar
    public abstract class Calisan
    {
        public abstract double maasinizNedir();
        public void mesaiyeBasla(string isim)
        {
            Console.WriteLine(isim + " mesaiye başladı..");
        }
    }
}
