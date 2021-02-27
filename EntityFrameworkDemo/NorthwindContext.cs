using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        // override : üzerine yazmak / ezmek
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        // Elimizdeki "Product" classımız ile veritabanındaki "Products"ı ilişkilendirdik aşağıda.
        public DbSet<Product> Products { get; set; }
    }
}
