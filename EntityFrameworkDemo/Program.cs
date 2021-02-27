using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET : veri tabanımıza bağlanmamızı, kontrol etmemizi ve sorgu yapmamızı sağlayan bir kütüphanedir.
            // Bu kütüphane sayesinde verilerimizi ekleyebilir, silebilir, güncelleyebiliriz. 
            // Entity Framework -- Bir ORM - Object Relational Mapping --> Nesnelerin veritabanı ile bağdaştırılması. Core'dan sonraki versiyonunun kullanılması önerilir.
            // NHibernate :
            // Dapper : ADO.NET'in kolaylaştırılmış versiyonudur.

            // GetAll();
            GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p=> p.CategoryId==categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
