using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Elif");

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);
        }
    }
}
