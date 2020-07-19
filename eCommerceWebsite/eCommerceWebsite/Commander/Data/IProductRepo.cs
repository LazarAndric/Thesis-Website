using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();

        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}