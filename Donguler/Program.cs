using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "java kursu"
            };
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
