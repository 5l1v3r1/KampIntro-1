using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Taşıt Kredisi Çıktı Alındı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
