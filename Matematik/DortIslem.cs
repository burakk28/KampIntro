using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void ıslem(int sayi1,int sayi2)
        {
            int sonuc1 = sayi1 + sayi2;
            int sonuc2 = sayi1 - sayi2;
            int sonuc3 = sayi1 / sayi2;
            int sonuc4 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
        }
       
    }
}
