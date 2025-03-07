using YakıtTüketim.Abstracts;
using YakıtTüketim.Classes;
public class Program { 
public static void Main(string[] args)
{
    Car bmw = new BMW();
    Car mercedes = new Mercedes();
    Car porsche = new Porsche();

    double ToplamYakıtTüketimi = bmw.YakıtTüketiminiHesapla() + mercedes.YakıtTüketiminiHesapla() + porsche.YakıtTüketiminiHesapla();

    
    Console.WriteLine($"Toplam Yakıt Tüketimi: {ToplamYakıtTüketimi} L");
}
    }