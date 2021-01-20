using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // Ürünle ilgili operasyonlar. (Ekleme/Silme/Güncelleme/Arama/Listeleme vs)
    {
        // encapsulation : iç içe / katmanlı mimari. 
        public void Add(Product product) // yazılan product'ların anlamı : Parametre olarak Product türünde değerler kullanacağımızı belirtir.
        {
            Console.WriteLine(product.ProductName + " Eklendi!");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi!");
        }

        // void : 

        // sayi1 ve sayi2 yi toplar ve int tipinde değer verir. Bu değeri program akışında return edildiği için tekrar kullanabiliriz.
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // sayi1 ve topla2 yi toplar fakat string türünde olur, program akışında tekrar kullanamayız.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
