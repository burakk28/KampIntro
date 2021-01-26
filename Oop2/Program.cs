using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12314";
            musteri1.Adi = "BURAK";
            musteri1.Soyadi = "Kara";
            musteri1.TcNo = "23213213";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12321312";


            // musteri1.SirketAdi = "?"; //Şirket adı burada soyutlamada hatasıdır.

            //Gerçek Müşteri-Tüzel Müşteri(Birbirinin yerine kullanılamaz.)
            //SO(L)ID


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
