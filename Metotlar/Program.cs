using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar: Tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            // Don't repeat yourself! - Kendini tekrar etme! - DRY
            // Clean Code - Temiz Kod / Best Practice - Doğru Uygulama Teknikleri

            Urun urun1 = new Urun();  // Bir class bu şekilde tanımlanır.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();  // Bir class bu şekilde tanımlanır.
            urun2.Adi = "Muz";
            urun2.Fiyati = 13;
            urun2.Aciklama = "Anamur Muzu";

            Urun urun3 = new Urun();  // Bir class bu şekilde tanımlanır.
            urun3.Adi = "Kayısı";
            urun3.Fiyati = 9;
            urun3.Aciklama = "Kayseri Kayısısı";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            // Type Safe - Tip Güvenli : Çalışacağımız veri tipini gireriz her zaman.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " - " + urun.Aciklama + " : " + urun.Fiyati + " TL ");
            }

            Console.WriteLine("---------------------------------------------------------------------------");

            // intance - örnek
            // syntax

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();
            sepetManager.Ekle();
        }
    }
}
