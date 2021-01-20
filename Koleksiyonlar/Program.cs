using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // array ler oluşturuldukları indisler kadardırlar. Dışarıdan yeni eleman eklemek istediğimizde ekleyemeyiz, eklemeye çalışsak da sıkıntı olur.
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                    Arrayler");
            Console.WriteLine("----------------------------------------------------------------------------------");
            string[] isimler = new string[] { "Elif", "Engin", "Murat", "Halil", "Kerem" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[4]);

            //Aşağıdaki örneği inceleyelim. "Kübra" isimli elemanı array'imize ekledik gibi görünüyor lakin, "isimler = new string[5]"
            // dediğimizde 5 elemanlı yeni bir array oluşturmuş oluyoruz. Bu array'in tüm indisleri boş geliyor.
            // Sonraki satıra baktığımızda "isimler[4] = "Kübra" demişiz. Bu sayede isimler[] array'imizin 4.indisini "Kübra" yapmış olduk.
            // Ama diğer indisler boş kaldı. Bu yüzden bu kullanım hatalı bir kullanımdır.

            //isimler = new string[5];
            //isimler[4] = "Kübra";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                           List ile yazılan arrayler");
            Console.WriteLine("----------------------------------------------------------------------------------");
            List<string> isimler2 = new List<string> {"Elif", "Engin", "Murat","Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("Zeynep");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);

            // List diye bir şey olmasaydı kendi koleksiyonumuzu nasıl mı yazardırk? ==>


        }
    }
}
