using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[1]);
            /*Arraylerde range her zaman ilk oluşturdugun zaman bellidir ayni 10. satırda yazdıgım gibi
             * şimdi diyeceksiniz 
             * isimler=new string[] paranterz arasınıda istegiğime göre yükseltirim fakat bu olmaz
             * çünkü bellekte 5 birimlik yer ayırtmış oluyorsun sıfırdan yani olmaz
             * bunun için c# a yeni gelmiş olan Koleksiyon Yapısını kullanıyoruz.
             * List i kullanmak için yukardan using System.Collections.Generic; çağırmamız gerekiyor
             */
            //List e böyle elemanda ekleyebiliriz ya da
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");
            // böyle elemanda ekleyebiliriz
            List<string> isimler = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
        }
    }
}
// CTRL K+ CTRL C SEÇTİĞİMİZ SATIRLARI KOMUT SATIRI YAPAR
