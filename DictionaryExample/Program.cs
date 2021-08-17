using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> AddCity = new MyDictionary<string, int>();
            AddCity.Add("eskisehir", 26);
            AddCity.Add("New yoruk", 01);
            AddCity.Add("Dortmund", 25);
            Console.WriteLine(AddCity.Count);




        }
    }
}
