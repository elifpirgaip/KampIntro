using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Interface'ler de o interface'i implemente eden class'ın referans numarasını tutar.
    // Interface'leri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar için kullanırız.
    // loglama : kim ne zaman hangi operasyonu çağırdı? Sistemde o an olan hareketleri döktüğümüz dökümdür.
    // logları : bir dosyada, veri tabanımızda tutabilir, sms olarak tutabiliriz, mail göndermesi yapabiliriz.

    interface IKrediManager
    {
        void Hesapla();
        void BirSeyYap();
    }
}
