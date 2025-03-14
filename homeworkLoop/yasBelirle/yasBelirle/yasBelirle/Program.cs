using System;

public class yasBelirle
{
    public static string YasKategorisiBelirle(int yas)
    {
        if (yas >= 0 && yas < 18)
        {
            return "Küçüksünüz";
        }
        else if (yas >= 18 && yas < 35)
        {
            return "Gençsiniz";
        }
        else if (yas >= 35 && yas < 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas >= 55 && yas < 75)
        {
            return "Yaşlısınız";
        }
        else if (yas >= 75 && yas <= 99)
        {
            return "Çok yaşlısınız";
        }
        else
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(YasKategorisiBelirle(25));  // Çıktı: Gençsiniz
        Console.WriteLine(YasKategorisiBelirle(40));  // Çıktı: Yetişkinsiniz
        Console.WriteLine(YasKategorisiBelirle(60));  // Çıktı: Yaşlısınız
        Console.WriteLine(YasKategorisiBelirle(80));  // Çıktı: Çok yaşlısınız
        Console.WriteLine(YasKategorisiBelirle(-5));  // Çıktı: Ya hiç doğmadınız ya da çoktan öldünüz...
        Console.WriteLine(YasKategorisiBelirle(100)); // Çıktı: Ya hiç doğmadınız ya da çoktan öldünüz...
    }
}