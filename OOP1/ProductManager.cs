using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi. ");

        }
       

        /*int,double, bool  deger tip
         diziler,class,abstract class,interface... referans tip 
         
         */

        /*Void Ne İşe Yarıyor
         * Void diye belirtiğimiz metotları şöyle düşünebiliriz ;
         * biz diyoruz ki git sil git güncelle veya git ekle yani onu bir emir kipinde çağırıyorz
         * işlemini yapıyoruz ve bitiyor biz bu işlem sonucunun ne oldugunla ihtiyacın yoksa void
         * olarak tanımlıyoruz
         * Peki Soru şu ben Topla yı Void ile yazsam ne olur veya İnt ile yazsam ne olur ?
         * public int Topla(int sayi1,int sayi2)
         * gibi yani yazsam nolur ?
         * Şimdi niye void var veya niye döndürme var 
         * şimdi void de sayi 1 ile sayi 2 yi topluyor yani işlemini yapıyor ve biz bunu
         * istediğimiz gibi setleyebiliriz ama intli olanlarlada sadece return olarak kullanılırız
         * yani geri döndürmek göstermek için yani işlem uygulayamıuyoruz üstüne
         * 
         */

    }
}
