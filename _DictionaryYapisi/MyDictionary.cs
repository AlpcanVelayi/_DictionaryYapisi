using System;

namespace _DictionaryYapisi
{
    class MyDictionary<KeyType, ValueType>
    {
        KeyType[] anahtarTipi;
        ValueType[] degerTipi;

        public MyDictionary()
        {
            anahtarTipi = new KeyType[0];
            degerTipi = new ValueType[0];
        }
        public void Add(KeyType item, ValueType item2)
        {
            KeyType[] tempAnahtar = anahtarTipi;
            ValueType[] tempDeger = degerTipi;

            anahtarTipi = new KeyType[anahtarTipi.Length + 1];
            degerTipi = new ValueType[degerTipi.Length + 1];

            for (int i = 0; i < tempAnahtar.Length; i++)
            {
                anahtarTipi[i] = tempAnahtar[i];
            }
            anahtarTipi[anahtarTipi.Length - 1] = item;

            for (int i = 0; i < tempDeger.Length; i++)
            {
                degerTipi[i] = tempDeger[i];
            }
            degerTipi[anahtarTipi.Length - 1] = item2;

        }
        public void Listeleme()
        {
            for (int i = 0; i < anahtarTipi.Length; i++)
            {
                Console.WriteLine("Numaranız : " + anahtarTipi[i] + "\t" + "Girdiğiniz değer : " + degerTipi[i]);
            }

        }

    }
}
