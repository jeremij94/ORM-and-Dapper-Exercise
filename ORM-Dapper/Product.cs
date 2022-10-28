using System;
namespace ORM_Dapper
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public int CategoryID { get; set; }
    }
}

