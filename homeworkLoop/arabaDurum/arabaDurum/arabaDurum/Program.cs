using System;

public class Program
{
    public static string ArabaDurumuBelirle(int arabaYasi)
    {
        if (arabaYasi >= 0 && arabaYasi < 10)
        {
            return "Arabanız yeni";
        }
        else if (arabaYasi >= 10 && arabaYasi < 20)
        {
            return "Servise götürmeniz gerekebilir";
        }
        else if (arabaYasi >= 20 && arabaYasi <= 30)
        {
            return "Arabanız hurdaya çıkabilir";
        }
        else
        {
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine(ArabaDurumuBelirle(5));   // Çıktı: Arabanız yeni
        Console.WriteLine(ArabaDurumuBelirle(15)); // Çıktı: Servise götürmeniz gerekebilir
        Console.WriteLine(ArabaDurumuBelirle(25)); // Çıktı: Arabanız hurdaya çıkabilir
        Console.WriteLine(ArabaDurumuBelirle(-5));  // Çıktı: Ya hiç üretilmedi ya da trafikten men edilmiştir
    }
}