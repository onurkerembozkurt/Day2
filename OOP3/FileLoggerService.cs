using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya ya loglandı");
        }
        /*Biz bunu ILoggerService i implemente etmeden de yazabilirdik fakat bu sefer
         * referans avantasını kullanamazdık.
         * 
         */
    }
}
