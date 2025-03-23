using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Random random = new Random();
        int tutulanSayi = random.Next(1, 101);
        int tahminSayisi = 0;
        int tahmin;

        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Tahmin etmeye çalış!");

        do
        {
            
            Console.Write("Tahmininiz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;

            
            if (tahmin < tutulanSayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin.");
            }
            else if (tahmin > tutulanSayi)
            {
                Console.WriteLine("Daha küçük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin.");
                Console.WriteLine("Toplam tahmin sayısı: " + tahminSayisi);
            }
        } while (tahmin != tutulanSayi);
    }
}