using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {   //sayi1 ne ?
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayilar1[0] ne ?
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
        /*İnt decimal float double bool bunlara biz deger tip diyoruz
         * ama 
         * array, class, string, interface bunlar ise refarans tip olarak çıkıyor.
         * 
         */
    }
}
