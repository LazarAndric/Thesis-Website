using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public interface IProductOfUserRepo
    {
        bool SaveChanges();

        IEnumerable<ProductOfUser> GetAllProductOfUsers();
        ProductOfUser GetProductOfUserById(int id);
        IEnumerable<ProductOfUser> GetProductsOfUserById(int id);
        void CreateProductOfUser(ProductOfUser productOfUser);
        void UpdateProductOfUser(ProductOfUser productOfUser);
        void DeleteProductOfUser(ProductOfUser productOfUser);
    }
    
}
