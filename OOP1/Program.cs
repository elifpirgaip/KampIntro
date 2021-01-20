using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 13;

            // Sıralama farketmeksizin yazabiliyoruz görüldüğü gibi. Bu kullanım daha kolay. 
            Product product = new Product { Id =2, CategoryId = 3, ProductName ="Kalem", UnitInStock = 5, UnitPrice= 25 };

            //PascalCase   //camelCase
            //Case sensetive = büyük küçük harf duyarlıdır.
            // stack - heap

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla(3,6);

            int toplamaSonucu = productManager.Topla(3, 7);
            Console.WriteLine(toplamaSonucu * 2);


            // int, double, bool... : değer tipleri
            // diziler, class, abstract class, interface... : referans tipler
            // ref out 
        }
    }
}
