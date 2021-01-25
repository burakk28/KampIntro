using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirme kamp";
            string kurs2 = "Program temel";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım geliştirme kamp", "Program temel", "JAVA","PHP" };
            for (int i = 0; i < kurslar.Length; i ++)
            {
            Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR BİTİŞ ");
            foreach (string a in kurslar)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("SAYFA SONU");
        }
    }
}
