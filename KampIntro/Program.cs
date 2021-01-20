using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği 
            // Don't repeat yourself - Kendini tekrar etme.
            // Alias - Değer tutucu.

            string kategoriEtiketi = "Kategoriler ";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Hoş Geldiniz!");
            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı Adı ya da Şifre! Lütfen Kontrol Ediniz...");
            }

            Console.WriteLine(kategoriEtiketi);

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Eşit Oku");
            }
        }
    }
}
