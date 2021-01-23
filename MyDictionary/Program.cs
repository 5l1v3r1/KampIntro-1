using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1, "Ahmet");
            ogrenciler.Add(2, "Mehmet");
            ogrenciler.Add(3, "Engin");
            ogrenciler.Add(4, "Murat");

            foreach (var item in ogrenciler.Value)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ogrenciler.Count);
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return values.Length; }
        }

        public TKey[] Key
        {
            get { return keys; }
            set { keys = value; }
        }

        public TValue[] Value
        {
            get { return values; }
            set { values = value; }
        }
    }
}
