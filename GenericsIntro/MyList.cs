using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor
        public MyList()
        {
            /*Constructor da aslında bir metotdur fakat başında 
                void falan yoktur biz bu class ı bir yerde new lersek bu otamatik çalışıacaktır
                yani direct çalışacaktır
            Constructor oldugunu class ile aynı isim oldugundan anlayabiliriz
              */
            items = new T[0];

        }


        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            //İNDEX 0 DAN BAŞLIYOR DİYE - 1 DEDİK BU ÇÜNKÜ ELEMAN SAYSINI VERİR
        }
    }
}
/*  Generic classları tanımlarken ; generic class demek çalışacagımız özel bir tip olucak demek
    <T> yazarsam programcı bu trigler arasına hangi tipi yazarsa onu generic yaparak verir
    Generic classlar tip bağımlı çalışır yani içerisinde metotlar varsa tip bağımlı olacaktır
    o yüzden generic classları MyList isimler =new MyList(); şeklinde çağıramayız
    Generic class yaratırken tip bağımlı oldugunu hesaba katmaktayız.
    Yani Generic Classlara çalışacagı tipleri söylememiz lazım.
    
 */
