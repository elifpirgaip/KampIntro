using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) // parametre olarak krediManager yerine buraya ne gönderirsek orası çalışır. 
        {
            // Başvuran bilgilerini değerlendirme
            // ...

            krediManager.Hesapla();

        }
    }
}
