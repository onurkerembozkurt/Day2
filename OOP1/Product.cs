using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Prop yazdıgımız zaman altta bi kare görülüyor buna snippet denir
    class Product // BİZ bu tarz classlara Entity diyebiliriz 

    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD CREATE READ UPDATE DELETE


    }
}
// bu tip classlarda sadece özellik olur
