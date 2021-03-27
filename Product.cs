using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //ürün ıd'si
        public int Id { get; set; }
        //ürünün katogori ıd'si
        public int CatagoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //ürünü stok adedi
        public int UnitInStocks  { get; set; }
    }
}
