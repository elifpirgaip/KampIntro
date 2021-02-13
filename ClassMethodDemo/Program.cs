using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Elif";
            musteri1.MusteriSoyad = "PİRGAİP";
            musteri1.MusteriKrediTip = "İhtiyaç Kredisi";
            musteri1.MusteriKrediNo = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Kübra";
            musteri2.MusteriSoyad = "Ay";
            musteri2.MusteriKrediTip = "Konut";
            musteri2.MusteriKrediNo = 12345;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "Emre";
            musteri3.MusteriSoyad = "Pir";
            musteri3.MusteriKrediTip = "Taşıt";
            musteri3.MusteriKrediNo = 1236;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAd = "Nedim";
            musteri4.MusteriSoyad = "Aydın";
            musteri4.MusteriKrediTip = "İhtiyaç";
            musteri4.MusteriKrediNo = 1237;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Update(musteri3);
            musteriManager.Delete(musteri4);

        }
    }
}
