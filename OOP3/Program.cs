using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            ////Biz bunu böyle çalıştırabiliriz fakat aynı zamanda böyle de çalıştırabiliriz

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
           
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
           
            IKrediManager konutKrediManager1 = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //Biz bunu IKrediManager diyerek de aynı sonucu alırdık demek ki interfacelerde, 
            //o interface i implemente eden class ın referance numarasını tutabiliyormuşş.

            BasuvuruManager basuvuruManager = new BasuvuruManager();

            //kırmızı oldugu zaman üstüne geldiğimizde görecez ki IKrediManager olan variable istiyor.
            /*Bu bilgi sizi mülakattan sonra işe sokucak bilgidir şöyle ki:
             * IKrediManager i implemente eden classlar var ve implemente olunca IKrediManager üzerinden
             * refarans oluşturabiliyorduk aynısı BaseClass yani inheritance içinde geçerli .
             */
            //basuvuruManager.BasvuruYap(ihtiyacKrediManager1);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1,konutKrediManager1 };
            // basuvuruManager.KrediOnBilgilendirmesiYap(krediler);
            basuvuruManager.BasvuruYap(ihtiyacKrediManager1,fileLoggerService);

        }
    }
}