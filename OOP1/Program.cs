using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 150;
            product1.UnitsInStock = 3;

            Product product2 = new Product { 
                Id = 2,
                CategoryId = 2,
                ProductName = "sandalye",
                UnitsInStock = 3,
                UnitPrice = 40 
            };
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);


        }
    }
}
