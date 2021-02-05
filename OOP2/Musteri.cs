using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {

        //  Bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, o nesneye ait değilmiş gibi duruyorsa alan, burada soyutlama 
        //  hatası yapıyoruzdur. İnheritance olmalı.
        //  Gerçek - Tüzel : Banka uygulamamız olsun. Müşterilerimiz hem gerçek hem de tüzeldir.
        //  Tüzel olanla Gerçek olan müşterilerimizin nesneleri farklı olmalı.
        //  SOLID

        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
