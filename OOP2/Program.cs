using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Pirgaip";
            musteri1.TcNo = "1234564835";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1245";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            // new : bellekteki referans no su demektir. 
            // Aşağıdaki Musteri class'ı hem GerceMusteri'nin ref'ini hem de TuzelMusteri'nin ref'ini tutar.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
        }
    }
}
