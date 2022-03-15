using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming  Convention 
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler" + "Sepete Eklendi"+" "+urun.Adi);
        

        }
        // böylede yapabilirdin ama class da içinde prop ları bildiğinden dolayı mantıksız<s
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {

        }

    }
}
