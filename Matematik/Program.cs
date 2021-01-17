using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            Console.WriteLine("Sonuc : " + dortIslem.Topla(2, 3));
        }
    }
}
