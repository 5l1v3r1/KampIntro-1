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


            Console.WriteLine("Hello World!");
        }
    }
}
