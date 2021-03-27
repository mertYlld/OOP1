using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStocks = 3;

            Product product2 = new Product { Id = 2, CatagoryId = 5, UnitInStocks=5,
            ProductName="Kalem", UnitPrice=35};

            //PascalCase   //camelCase
            //case sensitivy
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        }
    }
}
