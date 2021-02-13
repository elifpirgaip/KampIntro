using System;

namespace BasitETicaretOrn
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.UrunKategori = "Giyim";
            product1.UrunNo = 12345;
            product1.UrunAdi="Elbise";

            Product product2 = new Product();
            product2.Id = 2;
            product2.UrunKategori = "Teknolojik";
            product2.UrunNo = 1234567;
            product2.UrunAdi = "JBL Kulaklık";

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Id : " + product.Id + " / Ürün Kategori : " + product.UrunKategori + " / Ürün No : " + product.UrunNo + " / Ürün Adı : " + product.UrunAdi);
                Console.WriteLine(" ");
            }
        }
    }
}
