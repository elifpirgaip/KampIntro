using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual : Bireysel / Gerçek Müşteri
    // Inheritance : Miras Alma ==> GercekMusteri:Musteri
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
