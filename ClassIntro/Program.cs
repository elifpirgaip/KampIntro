using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# Kursu";
            kurs1.Egitmen = "Elif PİRGAİP";
            kurs1.izlemneOrani = 1254;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python Kursu";
            kurs2.Egitmen = "Yusuf Emre PİRGAİP";
            kurs2.izlemneOrani = 4521;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Html/Css Kursu";
            kurs3.Egitmen = "Azize PİRGAİP";
            kurs3.izlemneOrani = 124;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Unity Kursu";
            kurs4.Egitmen = "Mümtaz PİRGAİP";
            kurs4.izlemneOrani = 4563;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlemneOrani { get; set; }
    }
}
