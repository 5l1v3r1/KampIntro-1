using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //IKrediManager krediManager;
        //public BasvuruManager(IKrediManager krediManager)
        //{

        //}
        public void BasvuruYap(IKrediManager krediManager)
        {
            // başavuru bilgilerini degerlendirme
            //
            krediManager.Hesapla();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }







    }
}
