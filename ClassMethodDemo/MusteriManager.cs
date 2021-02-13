using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " Adlı Müşteri Eklendi!");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " Adlı Müşteri Güncellendi!");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " Adlı Müşteri Silindi!");
        }
    }
}
