using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------- Bu kısım çok önemli! --------------------------------------------------------
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            // Direkt bunu yazdırdığında "sayi1"in çıktısı ne olur? 
            // Cevap "30"dur. Çünkü 

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            // sayilar1[0] = ? Çıktısı ne olur?
            // Cevap 999 olur. Çünkü 

            // DEĞER TİPLER : Sayısal Veri Tipleri : int / decimal / float / double / bool ...  
            // REFERANS TİPLER : array / class / interface ... 

            // Bellekte "stack" ve "heap" diye iki alan vardır.
            // Değer tipler stack'te gerçekleşir.
            // Değer tiplerde, verilerin değerleri alınır. Örneğin; yukarıdaki örnekte sayi1 = sayi2 dediğimizde, sayi2'nin değeri sayi1'in değerine
            // atanır ve sayi2 ile olan ilişki kesilir. sayi2'nin değerinin daha sonradan değişmesi bir şeyi ifade etmez.
            // Referans tipler "heap"te gerçekleşir.
            // Yukarıdaki örneğe bakacak olursak, sayilar1[] = sayilar2[] dediğimizde, dizilerin referansları birbirlerine eşitlenir.
            // İki dizinin de referansları aynı olduğundan, sayilar2'de gerçekleşen değişiklikler sayilar1'i de etkiler. 
            // sayilar1'in ilk referans değeri değişip, sayilar2'nin referans değeri olduğundan, sayilar1 dizisi değerleri program tarafından bellekten silinir.

        }
    }
}
