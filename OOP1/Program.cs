using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;
            // Bu özellik c# da ilk önce yoktu sonra geldi yukardaki gördüğünüz alanı
            //alanları ayrı ayrı vermeden direk olarak süslü parantezin içine sırası önemsiz bir
            //şekilde yazabiliriz ;
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", 
                UnitsInStock = 5, UnitPrice = 35 };
            //Pascal Case  Camel Case
            //Case Sensitive
            //Referans Tiplerin Heap te Oluşabilmesi için onu new lemek gerekiyor
            ProductManager productManager=new ProductManager();
          

            //ref out 
        }
    }
}
