using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        // alttaki bloğun kısayolu "ctor" yazarak tab tuşuna 2 kez bastığımızda oto gelir. 
        // "ctror" = constructor : bir class new'ledniğinde çalışan bloğa denir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici değer. Yeni değer oluştururken eski değeri tutmak için kullanılır.
            items = new T[items.Length + 1]; // dizinin eleman sayısını bir artırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
