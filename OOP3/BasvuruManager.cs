using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection : 
        // Constructor injection :
        public void BasvuruYap(IKrediManager krediManageri, ILoggerService loggerService) // parametre olarak buraya ne gönderirsek orası çalışır. 
        {
            // Başvuran bilgilerini değerlendirme
            // ...

            krediManageri.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
