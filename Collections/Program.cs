using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];// referans tip olduğu için eski belleğe ulaşılamaz
            isimler[4] = "Error";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);// yeni adres boş

            List<string> isimler2 = new List<string> { "Engin1", "Murat1", "Kerem1", "Halil1" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Success");
            Console.WriteLine(isimler2[4]);

        }
    }
}
