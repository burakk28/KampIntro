using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";
            urun1.StokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";
            urun2.StokAdedi = 52;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("---------------------");
            }


            Console.WriteLine("---------------------METOTLAR---------------");
            //instance-örnek
            //encapsulation

            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("Armut", "Yeşil", 12,10);
            SepetManager.Ekle2("Karpuz", "Trabzon", 13,4);
            SepetManager.Ekle2("biber", "kırmızı", 12,8);

        }
        
    }
}
