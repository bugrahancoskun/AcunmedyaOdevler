using Composition.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Marka bmw = new Marka("BMW", "X5");
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("Sedan");
        decimal fiyat = 2000000;

        Araba bmwX5 = new Araba(bmw, kapi, pencere, kasa, fiyat);
        bmwX5.Yazdir();
    }
}
