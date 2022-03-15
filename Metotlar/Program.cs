using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakir Karpusu";
            Product[] products = new Product[] {product1,product2 };
            // TYPE SAFE TİP GÜVENLİ YANİ JAVA VE C# TİP GÜVENLİ

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("---------METODLAR-----------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product1);

            sepetManager.Ekle2("Kerm", "Kerem", 123);
        }
    }
}
/// Do not repaet yourself
/// 
/** sepetManager.Ekle2("Kerm", "Kerem", 123);
 * Mesala yukardaki metot oluşturduk sepet managerde ve bunu kullanacıgız
 * öncelikle bu metot aklımıza ilk gelmiş olabilir fakat sıkıntı yok bunun hatasını 
 * anlayarak kullanmamız gerektiğini anlamamız lazım
 * diyelim ben bu ekle2 fonksiyonunu farklı yerlerde kulllandım yani farklı internet
 * sayfalarında yani ve ilerde dendi ki ürünlere stok adedi eklensin benim bunun için her
 * seferinde ekle 2 fonksiyonunua stok adedi yazmam lazım ki bundan önce sepet manager da 
 * sign tanımlamam lazım buna özel olarak int stokAdedi gibi 
 * fakat prop oluşturdugumuz zaman yani product class ına gidip stokadedi diye prop oluşturursak 
 * main kısmına geldiğimiz zaman kodumuzun patlamadıgını göreceğiz işte buna "Encapsulation  " denir.
 * 
 * Encapsulation:
 * Aslında Encapsulation  sepetManager.Ekle2("Kerm", "Kerem", 123); ayrı ayrı yazıcagın olan düzensiz yapıyı
 * bir düzenin içine sokmaya yarar.
 * 
 * Instance-Örnek
 * Class tipinde bir örnek oluşturdugumuzda verilen ad.
 */


