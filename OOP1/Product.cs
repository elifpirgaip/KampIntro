using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity = varlık (entity ismi de verilebilir, ürünler için olan class larda.
    {
        public int Id { get; set; }  // Ana anahtar (Primary Key)
        public int CategoryId { get; set; } // Referans Anahtar
        public string ProductName { get; set;}
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; } // unit in stock = ürünün stok adedi

        // CRUD Operasyonları C : Create R : Read U : Update D : Delete

    }
}
