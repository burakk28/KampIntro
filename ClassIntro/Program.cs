using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "BURAK";
            int yas = 61;

            Kurs a=new Kurs();
            a.KursAdi = "C#";
            a.Egitmen = "BURAK";
            a.IzlenmeOrani = 78;


            Kurs b= new Kurs();
            b.KursAdi = "JAVA";
            b.Egitmen = "Ramo";
            b.IzlenmeOrani = 48;

            Kurs c = new Kurs();
            c.KursAdi = "C++";
            c.Egitmen = "Sarı";
            c.IzlenmeOrani = 71;

            //Console.WriteLine(a.KursAdi+" : "+a.Egitmen);

            Kurs[] kurslar = new Kurs[] { a,b,c};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : " +kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
