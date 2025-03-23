using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifiers.Classes
{
    
        public class Kullanici
        {
            
            private string adSoyad;
            private int yas;

            
            public string Email { get; set; }

            
            public string AdSoyad
            {
                get { return adSoyad; }
                set { adSoyad = value; }
            }

           
            public int Yas
            {
                get { return yas; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Yaş negatif olamaz!");
                    }
                    yas = value;
                }
            }

            public void BilgileriGoster()
            {
                Console.WriteLine("Ad Soyad: " + adSoyad);
                Console.WriteLine("Yaş: " + yas);
                Console.WriteLine("E-posta: " + Email);
            }
        }

    }
