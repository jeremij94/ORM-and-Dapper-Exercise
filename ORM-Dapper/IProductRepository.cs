using System;
namespace ORM_Dapper
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        public void CreateNewProduct(string name, double price, int categoryID);

    }
}

