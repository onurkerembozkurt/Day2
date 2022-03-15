using System;

class Program
{
    public static void Main(string[] args)
    {
        string kategoriEtiketi = "Kategori";
        //Type Safety= Tip Güvenliği
        //Var's are taking datas 
        double dolarDun = 7.45;
        double dolarBugun = 14.00;
        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Aşağı Ok");
        }else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Yukarı Ok");
        }
        else
        {
            Console.WriteLine("Düz Ok");
        }
    }

}