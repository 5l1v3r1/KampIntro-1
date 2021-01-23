using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            // Ekrandan başvuru yapıyorum
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService dataBaseLoggerService = new DatABaseLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { fileLoggerService, dataBaseLoggerService });
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { fileLoggerService, dataBaseLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,
                tasitKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
