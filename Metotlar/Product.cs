using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        // aşagıdakilerin hepsi property yani özellik 
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
//prop yapyıktan sonra tab a 2 kez basarsan şöyle bi yapı oluşturur. public int MyProperty { get; set; }