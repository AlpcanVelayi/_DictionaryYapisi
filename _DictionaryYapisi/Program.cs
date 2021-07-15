using System;
using System.Collections.Generic;

namespace _DictionaryYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> _group = new MyDictionary<int, string>();
            _group.Add(31, "Gözde Doğuer");
            _group.Add(484, "Alpcan Velayi");
            _group.Add(844, "Baran Velayi");
            _group.Add(112, "Ceyshan Gülistanzade");
            _group.Add(1, "Cimcim Velayi");

            _group.Listeleme();
            try
            {
                for (int i = 0; i < i + 1; i++)
                {
                    Console.WriteLine("\n");
                    int _newNo;
                    string _newName;
                    Console.Write("Eklemek istediğiniz kişinin numarasını giriniz : ");
                    _newNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Eklemek istediğiniz kişinin adını ve soyadını giriniz : ");
                    _newName = Console.ReadLine();
                    Console.Clear();
                    _group.Add(_newNo, _newName);

                    _group.Listeleme();

                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Değerlerden birini yanlış girdiniz\n");
                _group.Listeleme();
                Console.WriteLine("");
                for (int i = 0; i < i + 1; i++)
                {
                    int _newNo;
                    string _newName;
                    Console.Write("Eklemek istediğiniz kişinin numarasını giriniz : ");
                    _newNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Eklemek istediğiniz kişinin adını ve soyadını giriniz : ");
                    _newName = Console.ReadLine();
                    Console.Clear();
                    _group.Add(_newNo, _newName);

                    _group.Listeleme();
                    Console.WriteLine("\n");
                }

            }

        }
    }
}
