using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            // Yanlış Kullanım Biçimi. Dinamik bir site olmaz bbu şekilde!

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            string kurs1 = "C# Kursu";
            string kurs2 = "Python Kursu";
            string kurs3 = "Front-End Kursu";
            string kurs4 = "Back-End Kursu";
            string kurs5 = "Unity Kursu";
            string kurs6 = "Siber Güvenlik Kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine(kurs6);

            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            // Arrays - Diziler

            string[] kurslar = new string[]
            {
            "C# Kursu",
            "Python Kursu",
            "Front-End Kursu",
            "Back-End Kursu",
            "Unity Kursu",
            "Siber Güvenlik Kursu"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            // foreach döngüsü : Bu döngüyü arrayleri döndürmek için kullanırız. Çünkü for döngüsüne göre daha kolay -->

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
