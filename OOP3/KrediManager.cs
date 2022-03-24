using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {

       void Hesapla();
        void BiseyYap();
    }
}
/*Normalde burası base class tı
 * Konut, Ihtıyac, Tasit kredi managerlerini oluşturduk ve hepsinde 
 *  Hesapla fonksiyonu ortak diye KrediManageri ataları yaptık
 *  Bütün krediler Hesapla işini farklı ele alır mesala Konut kredisi
 *  nin faizi ve verdiği kredi farklıyken çıkan borç ile Ihtiyac kredisinin
 *  faizi ve verdiği kredi farklıdır.
 *  Yani KrediManager bir anlam ifade etmiyor yani sadece base yani ebebevny görevi görüyor
 *  yani tek başına bir anlam ifade etmiyor yani
 *  imzanin ayni oldugu ama içerisini farklı oldugu durumlarda biz base de oluşturdugumuz class olarak degilde
 *  interface olarak tanımlarız
 *  Interface aslında şablonumuz olarak görüyor.
 *  Bir interface şunu anlatır der ki: eger birisi bu interface i kullanırsa
 *  o arkadaş Hesapla metodunu içermek zorunda
 *  Mesala bir sınıf bir interface i böyle kullanıtyorsa gidip bakalım mesala ihtiyac kredisine 
 *  kırmızı yanıyor yani her kredi interface deki metodları içermek zorunda
 *  Bu arada okunurluğu arttırmak için interface lerin başına I koyarız
 *  İnterface i alan classlara implemente etti denilir mesala KonutKrediManager KrediManager i implemente etti gibi
 *  bunlara implementasyon işlemleri diyoruz.
 *  
 *  Interfaceler için önemli bir not
 *  Siz bir interface oluşturdugunuzda o interface in içinde operasyonlar alternatif sistemler için bir şablon 
 *  ve ek olarak referans tutucu olarak kullanılıyor
 *  YILDIZLI NOT
 *  Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
 *  Kredi türlerinin için hepsi hesapla vardır ama kodlaarı farklıdır faizler, dosyalar, kredi miktarı falan
 *  hesaplama işleri değişkenlik gösterir.Örneğin projenizde loglama yapmak istiyorsunuz
 *  Loglama kim ne zaman hangi operasyonu çağırdıgıdır.
 *  Loglamayı farklı yöntemlerle uygulayabiliriz
 *  Loglamayı bir dosyada tutabiliriz 
 *  veri tabanında tutabiliriz
 *  sms olarak atabiliriz
 *  birisi bi krediye başvuru yaptıgı zaman sms gitmeside mail gönderilmeside onu veri tabanına yazmamızda loglamanın 
 *  alternatifleridir.
 *  Veri tabanına yazarken veri tabanına yazma kodlar
 *  e mail yollarken e mail yazma kodları
 *  ..
 *  ...
 *  ..
 *  bunların hepsi loglamadır.
 *  
 *  
 */