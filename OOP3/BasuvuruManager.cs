using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasuvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran Bilgilerini Degerlendirme
            //.:............:..::::

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Eger böyle yaparsam tüm başvuruları Konut Kredisine bağımlı getirdim
            //fakat elimde herkesin referansını tutan bir arkadaş vardı IKrediManager.
            //hepsinin referansını tutugu için verebilirim istediğim kredileri yollayabilirim böylece
            krediManager.Hesapla();
            loggerService.Log();
            //Burada method injection yapıyoruz.
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
