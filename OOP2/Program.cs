using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri = new Musteri();
            //musteri.Id = 1;
            //musteri.Adi = "Engin";
            //musteri.Soyadi = "Demiroğ";
            //musteri.TcNo = "12345678901";
            //musteri.MusteriNo = "12345";
            //musteri.SirketAdi = "?";
            // Gerçek Müşteri - Tüzel Müşteri  birbirlerinin yerine kullanılamazlar
            // SOLID - L 

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 101;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345677891";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 102;
            musteri2.MusteriNo = "123457";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "3214569870";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);



        }
    }
}
