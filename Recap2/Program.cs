using System;

namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Basit bir basketbolcu takip otomasyonu oluşturunuz. 
             * Basketbolcuların özellikleri ad, yaş ve boy olsun. 4 farklı basketbolcu oluşturunuz.
             * Basketbolcuları boylarına göre 1.85'ten küçük ve büyük olacak şekilde iki gruba ayırınız.
             * Bu basketbolcuları ekranda "Ad: X Yaş: XX Boy: X.XX Boy Grubu: "UZUN/KISA" formatında listeleyeniz. 
            Örnek çıktı:
            Ad: Ahmet Yaş: 21 Boy: 1.86 Boy Grubu: UZUN
            Ad: Mehmet Yaş: 25 Boy: 1.83 Boy Grubu: KISA
            gibi.*/
            Basketbolcu basketci1 = new Basketbolcu();
            basketci1.Name = "Kerem";
            basketci1.Age = 20;
            basketci1.Height = 185;
            

        }

        class Basketbolcu
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public float Height { get; set; }
            public string whatIsHeLike;
        }
    }
           
}
    

