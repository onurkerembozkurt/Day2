using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string kurs1 = "Yazılım Geliştirme Kampı ";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";*/
            string[] kurslar = { "Java Kursu", "Yazılım Geliştirme Kursu", "Progamlamaya Başlangıç Kursu" };


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            //Classlara giriş;

        }
    }
}