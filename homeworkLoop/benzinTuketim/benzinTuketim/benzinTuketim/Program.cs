using benzinTuketim.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5),
            new Araba("Ford", "Focus", 7.2),
            new Araba("BMW", "X5", 9.8),
            new Araba("Honda", "Civic", 5.9)
        };

        
        double toplamTuketim = 0;
        foreach (var araba in arabalar)
        {
            araba.BilgileriYazdir(); 
            toplamTuketim += araba.BenzinTuketimi; 
        }
        Console.WriteLine($"\nToplam Benzin Tüketimi: {toplamTuketim} L/100 km");
    }
}
