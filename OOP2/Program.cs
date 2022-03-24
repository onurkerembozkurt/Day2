using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bugün Soyutlama nın mantığını konuşacağız. Soyutlama bizi şirketlerde önemli yere getirecektir.
            //
            /*
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demirog";
            musteri1.Id = 1;
            musteri1.TcNo = "2222222222";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";
            */
            //Gerçek Müşteri-Tüzel Müşteri bunlar müşteri ama farklı müşteri o yüzden asla birbiri yerine kullanılamaz
            //SOLID
            //SIRF BİRBİRİNE BENZİYOR DİYE İNHERİTİNCE YAPMA 

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demirog";
            musteri1.TcNo = "12344556";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            Musteri musteri5 = new Musteri();
            //Eger senin BASE sınıfın varsa o Referans tutucudur.

        }
    }
}
