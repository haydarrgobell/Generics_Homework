using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count); // count dizinin eleman sayısı verir.
           

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İzmir");
            Console.WriteLine(sehirler2.Count);
            

        }
    }
    class MyList<T> // Generic Class T <--- Type dan gelen veri tipi değeri istediğimiz herhangi bir şey verebilirz.
    {
        // Generic Class'lar arka planda aslında bir Array çalıştırırlar.
        T[] _array; // T bizim type'ımız dı gelen type neyse onunla çalışacak bir dizi oluşturduk.
        T[] _tempArray; /* _array yeni referans değerindeki +1 elemanlı diziyi tutacağı için eski veriler kaybolacaktır.
                            eski veriler kaybolmasın diye eski dizinin referans değerini _tempArray isimli diziye atadık. */

        public MyList() // MyList new'lendiği anda çalışacak olan contractor
        {
            _array = new T[0]; // çalıştığı anda 0 elemanlı T tipinde bir dizi oluşturduk.
        }
        public void Add(T item) // T=Type yani T türünde gelen item
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1]; // eleman eklendikten sonra eleman sayısını 1 artırdık ve _array artık yeni new'lediğimiz referans değerindeki +1 elemanlı diziyi tutuyor.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // _tempArray dizisindeki verileri 0'dan başlayarak tek tek +1 elemanlı diziye atadık.
                                           // son elemanımız ise boş durmakta.
            }
            _array[_array.Length - 1] = item; // eleman sayıları 0'dan başladığı için 4. değer 3. index'e geleceği için _array.Length - 1 
                                              // değerini parametreden gelen item'ın tutuğu değeri atadık.

        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
