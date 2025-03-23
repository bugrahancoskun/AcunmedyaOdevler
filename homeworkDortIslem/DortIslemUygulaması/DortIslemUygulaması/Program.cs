using System;

namespace DortIslemUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiminiz (1-4): ");
            int secim = Convert.ToInt32(Console.ReadLine());

            
            double sonuc = 0;
            bool gecerliIslem = true;

            
            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işlemi seçildi.");
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Çıkarma işlemi seçildi.");
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma işlemi seçildi.");
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        sonuc = (double)sayi1 / sayi2;
                        Console.WriteLine("Bölme işlemi seçildi.");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                        gecerliIslem = false;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi!");
                    gecerliIslem = false;
                    break;
            }

            
            if (gecerliIslem)
            {
                Console.WriteLine("İşlem sonucu: " + sonuc);
            }

            
            Console.WriteLine("Programı sonlandırmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}