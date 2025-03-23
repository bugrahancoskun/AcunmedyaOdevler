using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        int[] sayilar = new int[5];
        int toplam = 0;

        Console.WriteLine("Lütfen 5 adet sayı girin:");

        
        for (int i = 0; i < 5; i++)
        {
            Console.Write((i + 1) + ". sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }

        
        double ortalama = (double)toplam / 5;

        
        Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
    }
}
