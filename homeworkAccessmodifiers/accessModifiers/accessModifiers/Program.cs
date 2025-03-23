using accessModifiers.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        
        Kullanici kullanici = new Kullanici();

       
        kullanici.AdSoyad = "Bugrahan Coskun";
        kullanici.Yas = 25;
        kullanici.Email = "bugrahancoskun@gmail.com";

        
        kullanici.BilgileriGoster();

        
        try
        {
            kullanici.Yas = -5;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
