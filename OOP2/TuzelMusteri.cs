using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorporate : Tüzel
    // Inheritance : Miras Alma ==> TuzelMusteri:Musteri 
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
