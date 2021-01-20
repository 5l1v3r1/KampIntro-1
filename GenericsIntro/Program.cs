using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic class'lar tip belirtilmeden new'lenemez
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Celal");

            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler.Count());

            isimler.Add("Ayşe");

            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler.Count());

            isimler.Add("Erdal");

            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler.Count());

            isimler.Add("Ercan");

            Console.WriteLine(isimler.Length);
            Console.WriteLine(isimler.Count());

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler);
            }


        }
    }
}
