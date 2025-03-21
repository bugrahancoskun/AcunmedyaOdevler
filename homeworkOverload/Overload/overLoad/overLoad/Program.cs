using overLoad.Classes;

class Program
{
    static void Main(string[] args)
    {
        Matematik matematik = new Matematik();

        // örnek çıktılar
        int toplam2Int = matematik.Toplama(5, 10);
        int toplam3Int = matematik.Toplama(5, 10, 15);

        
        double toplam2Double = matematik.Toplama(5.5, 10.5);
        double toplam3Double = matematik.Toplama(5.5, 10.5, 15.5);

        
        int carpim2Int = matematik.Carpma(5, 10);
        int carpim3Int = matematik.Carpma(5, 10, 2);

       
        double carpim2Double = matematik.Carpma(5.5, 10.5);
        double carpim3Double = matematik.Carpma(5.5, 10.5, 2.0);

       
        Console.WriteLine("Toplama İşlemleri:");
        Console.WriteLine($"2 int toplam: {toplam2Int}");
        Console.WriteLine($"3 int toplam: {toplam3Int}");
        Console.WriteLine($"2 double toplam: {toplam2Double}");
        Console.WriteLine($"3 double toplam: {toplam3Double}");

        Console.WriteLine("\nÇarpma İşlemleri:");
        Console.WriteLine($"2 int çarpım: {carpim2Int}");
        Console.WriteLine($"3 int çarpım: {carpim3Int}");
        Console.WriteLine($"2 double çarpım: {carpim2Double}");
        Console.WriteLine($"3 double çarpım: {carpim3Double}");
    }
}
