
using maasHesap.Abstracts;
GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programcı pr = new Programcı();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Çalışanların Toplam Maaşı: " + toplamMaas);