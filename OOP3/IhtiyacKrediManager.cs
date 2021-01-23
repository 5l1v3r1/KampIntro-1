using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("İhtiyaç Kredisi Çıktı Alındı");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
