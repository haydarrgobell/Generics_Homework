using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======REFERENCE TYPES=======\n");
            string metin1 = "Merhaba";
            string metin2 = "Güle Güle";

            metin1 = metin2;

            metin2 = "Hoşça kal\n";

            Console.WriteLine(metin2);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine(sayilar2[0]+"\n");

            Console.WriteLine("=======VALUE TYPES=======\n");

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 200;

            Console.WriteLine(sayi1);





        }
    }
}
