using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(34, "İstanbul");
            dictionary.Add(35, "İzmir");

            foreach (var city in dictionary)
            {
                Console.WriteLine(city);
            }
        }
    }
}
