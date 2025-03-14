using calisanMaas.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        
        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("Bugrahan", "Coskun", "Genel Müdür", 50000, "Yönetim"),
            new Calisan("Emre", "Kurnaz", "Müdür", 30000, "Satış"),
            new Calisan("Mehmet", "Demir", "Programcı", 15000, "IT"),
            new Calisan("Zeynep", "Aksoy", "Stajyer", 5000, "IT")
        };

        decimal toplamMaas = 0;
        foreach (var calisan in calisanlar)
        {
            calisan.BilgileriYazdir(); 
            toplamMaas += calisan.Maas; 
        }

        
        Console.WriteLine($"\nToplam Maaş: {toplamMaas}");
    }
}
