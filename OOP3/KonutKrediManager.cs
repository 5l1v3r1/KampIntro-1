using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Konut Kredisi Çıktı Alındı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
