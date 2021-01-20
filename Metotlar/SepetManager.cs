using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isim okunabilirliği
        // bir yerde normal parantez varsa "()" -> şeklinde, orada method vardır.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi!");
            Console.WriteLine("-------------------------------------------------------------");
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
